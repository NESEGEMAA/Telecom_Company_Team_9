﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Telecom_Company_Team_9
{
    public partial class LastFiveMonthSubscribedPlans : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ViewLastFiveMonthsPlans(object sender, EventArgs e)
        {
            // Get the connection string from Web.config
            string connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();

            // SQL query to get data from the function
            string data = "SELECT LastFiveMonthsPlans.* FROM dbo.Subscribed_plans_5_Months (@mobileNo) AS LastFiveMonthsPlans";

            // Get the mobile number from the input field
            Int32 mobileNumber = int.Parse(LastFiveMonthsPlansInputNumber.Text);

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand cmd = new SqlCommand(data, conn))
                    {
                        // Add parameter to prevent SQL injection
                        cmd.Parameters.AddWithValue("@mobileNo", mobileNumber);

                        // Open the connection
                        conn.Open();

                        // Use SqlDataAdapter to fill the DataTable
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Check if data exists
                        if (dt.Rows.Count > 0)
                        {
                            LastFiveMonthsPlans.DataSource = dt;
                            LastFiveMonthsPlans.DataBind();
                            LastFiveMonthsPlansErrorMessage.Visible = false;
                        }
                        else
                        {
                            LastFiveMonthsPlansErrorMessage.Text = "No plans available to display for this number.";
                            LastFiveMonthsPlansErrorMessage.Visible = true;
                            LastFiveMonthsPlans.DataSource = null;
                            LastFiveMonthsPlans.DataBind();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LastFiveMonthsPlansErrorMessage.Text = "An error occurred: " + ex.Message;
                LastFiveMonthsPlansErrorMessage.Visible = true;
            }
        }
    }
}