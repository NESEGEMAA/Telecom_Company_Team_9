using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.Services.Description;

namespace Telecom_Company_Team_9
{
    public partial class RenewSubscription : System.Web.UI.Page
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

            InputMobileNumber.Text = Session["Mobile"] as string;
        }

        protected void Renew(object sender, EventArgs e)
        {
            // Get the connection string from Web.config
            string connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();

            // SQL query to get data from the function
            string data = "EXEC Initiate_plan_payment @mobile_num = @mobileNo, @amount = @inputAmount, @payment_method = @paymentMethod" +
                ", @plan_id = @planID";

            // Get the mobile number from the input field

            try
            {
                String mobileNumber = InputMobileNumber.Text;
                Int32 rechargeAmount = int.Parse(InputAmount.Text);
                string paymentMethod = paymentMethodDropDownList.SelectedValue;
                Int32 planID = int.Parse(InputPlanId.Text);
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand cmd = new SqlCommand(data, conn))
                    {
                        // Add parameter to prevent SQL injection
                        cmd.Parameters.AddWithValue("@mobileNo", mobileNumber);
                        cmd.Parameters.AddWithValue("@inputAmount", rechargeAmount);
                        cmd.Parameters.AddWithValue("@paymentMethod", paymentMethod);
                        cmd.Parameters.AddWithValue("@planID", planID);

                        // Open the connection
                        conn.Open();

                        // Execute the stored procedure
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            Message2.Text = "Transaction completed";
                        }
                        else
                        {
                            Message.Text = "Transaction failed";
                        }
                        Message.Visible = true;
                        Message2.Visible = true;
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