﻿using System;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Telecom_Company_Team_9
{
    public partial class RechargeBalance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Visible = false;
            Message2.Visible = false;
            if (Session["UserRole"] == null || Session["UserRole"].ToString() != "Customer")
            {
                // Redirect to login or access denied page if the user is not a customer
                Response.Redirect("~/LoginCustomer.aspx");
            }

            if (!IsPostBack)
                InputMobileNumber.Text = Session["Mobile"] as string;
        }

        protected void Recharge(object sender, EventArgs e)
        {
            // Get the connection string from Web.config
            string connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();

            // SQL query to get data from the function
            string data = "EXEC Initiate_balance_payment @MobileNo = @mobileNo, @amount = @inputAmount, @payment_method = @paymentMethod";

            try
            {
                // Get the mobile number from the input field
                String mobileNumber = InputMobileNumber.Text;
                Int32 rechargeAmount = int.Parse(InputAmount.Text);
                string paymentMethod = paymentMethodDropDownList.SelectedValue;

                try
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        using (SqlCommand cmd = new SqlCommand(data, conn))
                        {
                            // Add parameter to prevent SQL injection
                            cmd.Parameters.AddWithValue("@mobileNo", mobileNumber);
                            cmd.Parameters.AddWithValue("@inputAmount", rechargeAmount);
                            cmd.Parameters.AddWithValue("@paymentMethod", paymentMethod);

                            // Open the connection
                            conn.Open();

                            // Execute the stored procedure
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                Message2.Text = "Transaction completed";
                            }
                            else
                            {
                                Message2.Text = "Transaction failed";
                            }

                            Message.Visible = false;
                            Message2.Visible = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Message.Text = "Mobile Number Not Found";
                    Message.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Message.Text = "Invalid Input: " + ex.Message;
                Message.Visible = true;
            }
        }
    }
}