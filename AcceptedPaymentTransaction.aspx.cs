﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Reflection.Emit;

namespace Telecom_Company_Team_9
{
    public partial class AcceptedPaymentTransaction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Visible = false;
            PaymentsNumLabel.Visible = false;
            SumOfPointsLabel.Visible = false;

            if (Session["UserRole"] == null || Session["UserRole"].ToString() != "Admin")
            {
                // Redirect to login or access denied page if the user is not an admin
                Response.Redirect("~/LoginAdmin.aspx");
            }

            PaymentsNumLabel.Text = "Number of Payments: ";
            SumOfPointsLabel.Text = "Sum of points over payments: ";
        }


        protected void RetrievePaymentsButton_Click(object sender, EventArgs e)
        {
            PaymentsNumLabel.Text = "Number of Payments: ";
            SumOfPointsLabel.Text = "Sum of points over payments: ";

            // Get the connection string from Web.config
            string connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();

            // SQL query to get data from the function
            string data = "Exec Account_Payment_Points @mobile_num = @mobileNo";

            string mobileNo = InputNumber.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(mobileNo) || !long.TryParse(mobileNo, out _))
            {
                Message.Text = "Invalid mobile number. Please enter a valid number.";
                Message.Visible = true;
                PaymentsNumLabel.Visible = false;
                SumOfPointsLabel.Visible = false;
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand cmd = new SqlCommand(data, conn))
                    {
                        cmd.Parameters.AddWithValue("@mobileNo", mobileNo);

                        // Open the connection
                        conn.Open();

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                // Access each column value by alias
                                string paymentCount = reader.IsDBNull(0) ? "N/A" : reader[0].ToString(); // First column - count of paymentID
                                string totalPoints = reader.IsDBNull(1) ? "N/A" : reader[1].ToString();   // Second column - sum of pointsAmount

                                // Display the values manually (using Labels or any other control)
                                PaymentsNumLabel.Text += paymentCount;
                                SumOfPointsLabel.Text += totalPoints;
                                PaymentsNumLabel.Visible = true;
                                SumOfPointsLabel.Visible = true;
                            }

                            Message.Visible = false;
                        }
                        else
                        {
                            Message.Text = "No payments available to display.";
                            Message.Visible = true;
                            PaymentsNumLabel.Visible = false;
                            SumOfPointsLabel.Visible = false;
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                Message.Text = "A database error occurred: " + sqlEx.Message;
                Message.Visible = true;
                PaymentsNumLabel.Visible = false;
                SumOfPointsLabel.Visible = false;
            }
            catch (Exception ex)
            {
                Message.Text = "An unexpected error occurred: " + ex.Message;
                Message.Visible = true;
                PaymentsNumLabel.Visible = false;
                SumOfPointsLabel.Visible = false;
            }
        }


    }
}