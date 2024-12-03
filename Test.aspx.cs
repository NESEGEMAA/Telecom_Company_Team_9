using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecom_Company_Team_9
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {
            String kofta = TextBox1.Text;
            kofta.PadRight(11);
            e.Command.Parameters["@mobile"].Value = kofta;
            Response.Write("ha5a");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewLastFiveMonthsPlans(sender, e);
        }

        protected void ViewLastFiveMonthsPlans(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();

            String data = "SELECT Account_SMS_Offers_1.* FROM dbo.Account_SMS_Offers(@mobile) AS Account_SMS_Offers_1";

            string mobileNumber = TextBox1.Text;

            // Define the mobile number pattern
            string pattern = @"^\+?[0-9]{10,15}$";

            // Validate the mobile number using Regex
            if (Regex.IsMatch(mobileNumber, pattern))
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand cmd = new SqlCommand(data, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@mobile", mobileNumber);

                        // Open the connection and execute the query
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        SqlDataAdapter reader = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        reader.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Label1.Visible = false;
                        }
                        else
                        {
                            Label1.Text = "No plans available to display.";
                            Label1.Visible = true;
                            GridView1.Visible = false;
                        }

                        conn.Close();
                    }
                }
            }
            else
            {
                Label1.Text = "Invalid mobile number format";
                Label1.Visible = true;
                GridView1.Visible = false;

            }
        }
    }
}