using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Telecom_Company_Team_9
{
    public partial class CustomerComponent3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ViewAllShops(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            String data = "SELECT * FROM allShops";
            SqlCommand cmd = new SqlCommand(data, conn);

            SqlDataAdapter reader = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            reader.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                AllShopsGridView.DataSource = dt;
                AllShopsGridView.DataBind();
                AllShopsErrorMessage.Visible = false;
            }
            else
            {
                AllShopsErrorMessage.Text = "No benefits available to display.";
                AllShopsErrorMessage.Visible = true;
            }
        }

        protected void ViewLastFiveMonthsPlans(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();

            String data = "SELECT * FROM dbo.Subscribed_plans_5_Months (@mobileNo)";

            string mobileNumber = LastFiveMonthsPlansInputNumber.Text;

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
                        cmd.Parameters.AddWithValue("@mobileNo", mobileNumber);

                        // Open the connection and execute the query
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        SqlDataAdapter reader = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        reader.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            AllShopsGridView.DataSource = dt;
                            AllShopsGridView.DataBind();
                            LastFiveMonthsPlansErrorMessage.Visible = false;
                        }
                        else
                        {
                            LastFiveMonthsPlansErrorMessage.Text = "No plans available to display.";
                            LastFiveMonthsPlansErrorMessage.Visible = true;
                        }

                        conn.Close();
                    }
                }
            }
            else
            {
                LastFiveMonthsPlansErrorMessage.Text = "Invalid mobile number format";
                LastFiveMonthsPlansErrorMessage.Visible = true;
            }
        }
    }
}