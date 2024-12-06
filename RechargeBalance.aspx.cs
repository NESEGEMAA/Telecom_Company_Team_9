using System;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Telecom_Company_Team_9
{
    public partial class RechargeBalance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Visible = false;
            if (Session["UserRole"] == null || Session["UserRole"].ToString() != "Customer")
            {
                // Redirect to login or access denied page if the user is not a customer
                Response.Redirect("~/LoginCustomer.aspx");
            }

            InputAmount.Text = Session["Mobile"] as string;
        }

        protected void Recharge(object sender, EventArgs e)
        {
            // Get the connection string from Web.config
            string connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();

            // SQL query to get data from the function
            string data = "EXEC Initiate_balance_payment @mobile_num = @mobileNo, @amount = @inputAmount, @payment_method = @paymentMethod";

            try
            {
                // Get the mobile number from the input field
                Int64 mobileNumber = int.Parse(InputMobileNumber.Text);
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
            catch (Exception ex)
            {
                Message.Text = "Invalid Input: " + ex.Message;
                Message.Visible = true;
            }
        }
    }
}