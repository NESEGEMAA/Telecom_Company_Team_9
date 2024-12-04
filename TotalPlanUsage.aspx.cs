using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecom_Company_Team_9
{
    public partial class TotalUsage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox5.Visible = true;
            Label2.Visible = false;
            Calendar2.Visible = true;
            Button10.Visible = true;
        }
        protected void ShowTotalUsage(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();

            String data = "SELECT Account_Usage_Plan_1.* FROM dbo.Account_Usage_Plan(@mobile_no,@from_date) AS Account_Usage_Plan_1";

            string mobileNumber = TextBox5.Text;
            DateTime date = Calendar2.SelectedDate;

            // Define the mobile number pattern
            string pattern = @"^\+?[0-9]{10,15}$";

            // Validate the mobile number using Regex
            if (Regex.IsMatch(mobileNumber, pattern) && date <= DateTime.Today)
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand cmd = new SqlCommand(data, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@mobile_no", mobileNumber);
                        cmd.Parameters.AddWithValue("@from_date", date);

                        // Open the connection and execute the query
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        SqlDataAdapter reader = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        reader.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            GridView7.DataSource = dt;
                            GridView7.DataBind();
                            GridView7.Visible = true;
                            Label2.Visible = false;
                        }
                        else
                        {
                            Label2.Text = "No plans available to display.";
                            Label2.Visible = true;
                            GridView7.Visible = false;
                        }

                        conn.Close();
                    }
                }
            }
            else
            {
                Label2.Text = "Invalid Input Format";
                Label2.Visible = true;
                GridView7.Visible = false;

            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            ShowTotalUsage(sender, e);
        }
    }
}