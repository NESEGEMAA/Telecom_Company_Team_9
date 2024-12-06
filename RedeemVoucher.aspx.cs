using System;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Telecom_Company_Team_9
{
    public partial class RedeemVoucher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Message2.Visible = false;
            Message.Visible = false;
            if (Session["UserRole"] == null || Session["UserRole"].ToString() != "Customer")
            {
                // Redirect to login or access denied page if the user is not a customer
                Response.Redirect("~/LoginCustomer.aspx");
            }
        }

        protected void Redeem(object sender, EventArgs e)
        {
            // Get the connection string from Web.config
            string connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();

            // SQL query to get data from the function
            string data = "EXEC Redeem_voucher_points @mobile_num = @mobileNo, @voucher_id = @voucherID";

            try
            {
                // Get the mobile number from the input field
                Int64 mobileNumber = int.Parse(InputMobileNumber.Text);
                Int32 voucherID = int.Parse(InputVoucherID.Text);

                try
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        using (SqlCommand cmd = new SqlCommand(data, conn))
                        {
                            // Add parameter to prevent SQL injection
                            cmd.Parameters.AddWithValue("@mobileNo", mobileNumber);
                            cmd.Parameters.AddWithValue("@voucherID", voucherID);

                            // Open the connection
                            conn.Open();

                            // Execute the stored procedure
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                Message2.Text = "Voucher redeemed successfully!";
                            }
                            else
                            {
                                Message2.Text = "Not enough points or redemption failed";
                            }

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
            catch
            {
                Message.Text = "Invalid input";
                Message.Visible = true;
            }
        }
    }
}