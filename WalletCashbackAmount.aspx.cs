using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecom_Company_Team_9
{
    public partial class WalletCashbackAmount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserRole"] == null || Session["UserRole"].ToString() != "Admin")
            {
                // Redirect to login or access denied page if the user is not an admin
                Response.Redirect("~/LoginAdmin.aspx");
            }
        }

        protected void RetrieveAverageTransactionsAmountButton_Click(object sender, EventArgs e)
        {
            // Get the connection string from Web.config
            string connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();

            // SQL query to get data from the function
            string data = "SELECT Wallet_Cashback_Amount_1.* FROM dbo.Wallet_Cashback_Amount(@walletID,@planID) AS Wallet_Cashback_Amount_1";

            try
            {
                Int32 wallet_ID = int.Parse(InputNumber.Text);
                Int32 plan_ID = int.Parse(InputNumber2.Text);
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand cmd = new SqlCommand(data, conn))
                    {
                        cmd.Parameters.AddWithValue("@planID", plan_ID);
                        cmd.Parameters.AddWithValue("@walletID", wallet_ID);

                        // Open the connection
                        conn.Open();
                        int cashback = (Int32)cmd.ExecuteScalar();
                        if (cashback > 0)
                        {
                            Message.Text = "Your Cashback is: "  + cashback;
                            Message.Visible = true;
                        }
                        else
                        {
                            Message.Text = "No Cashback Amounts available to display.";
                            Message.Visible = true;
                        }
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