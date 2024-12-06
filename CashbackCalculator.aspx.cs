﻿using System;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Telecom_Company_Team_9
{
    public partial class CashbackCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserRole"] == null || Session["UserRole"].ToString() != "Customer")
            {
                // Redirect to login or access denied page if the user is not a customer
                Response.Redirect("~/LoginCustomer.aspx");
            }
        }

        protected void Calculate(object sender, EventArgs e)
        {
            // Get the connection string from Web.config
            string connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();

            // SQL query to get data from the function
            string data = "EXEC Payment_wallet_cashback @mobile_num = @mobileNo, @payment_id = @paymentID, @benefit_id = @benefitID";

            // Get the mobile number from the input field
            Int64 mobileNumber = int.Parse(InputMobileNumber.Text);
            Int32 paymentID = int.Parse(InputPaymentID.Text);
            Int32 benefitID = int.Parse(InputBenefitID.Text);

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand cmd = new SqlCommand(data, conn))
                    {
                        // Add parameter to prevent SQL injection
                        cmd.Parameters.AddWithValue("@mobileNo", mobileNumber);
                        cmd.Parameters.AddWithValue("@paymentID", paymentID);
                        cmd.Parameters.AddWithValue("@benefitID", benefitID);

                        // Open the connection
                        conn.Open();

                        // Execute the stored procedure
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            Message.Text = "Transaction completed";
                        }
                        else
                        {
                            Message.Text = "Transaction failed";
                        }

                        Message.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Message.Text = "An error occurred: " + ex.Message;
                Message.Visible = true;
            }
        }
    }
}