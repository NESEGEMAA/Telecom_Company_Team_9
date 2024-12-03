﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecom_Company_Team_9
{
    public partial class RedeemVoucher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
                Int32 mobileNumber = int.Parse(InputMobileNumber.Text);
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
                                Message.Text = "Voucher redeemed successfully!";
                            }
                            else
                            {
                                Message.Text = "Not enough points or redemption failed";
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
            catch
            {
                Message.Text = "Invalid input";
                Message.Visible = true;
            }
        }
    }
}