using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Web.Configuration;

namespace Telecom_Company_Team_9
{
    public partial class AllSMSOffers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox4.Visible = true;
            Button9.Visible = true;
            Label1.Visible = false;
        }

        protected void ShowAccountSMSOffers(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();

            String data = "SELECT Account_SMS_Offers_1.* FROM dbo.Account_SMS_Offers(@mobile) AS Account_SMS_Offers_1";

            String mobileNumber = TextBox4.Text;

            // Define the mobile number pattern
            String pattern = @"^\+?[0-9]{10,15}$";

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
                            GridView6.DataSource = dt;
                            GridView6.DataBind();
                            GridView6.Visible = true;
                            Label1.Visible = false;
                        }
                        else
                        {
                            Label1.Text = "No plans available to display.";
                            Label1.Visible = true;
                            GridView6.Visible = false;
                        }

                        conn.Close();
                    }
                }
            }
            else
            {
                Label1.Text = "Invalid mobile number format";
                Label1.Visible = true;
                GridView6.Visible = false;
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            ShowAccountSMSOffers(sender, e);
        }
    }
}