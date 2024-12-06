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
            Message.Visible=false;  
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

            try
            {
                // Validate inputs
                if (!int.TryParse(InputNumber.Text, out int wallet_ID))
                {
                    Message.Text = "Invalid Wallet ID. Please enter a valid number.";
                    Message.Visible = true;
                    return;
                }

                if (!int.TryParse(InputNumber2.Text, out int plan_ID))
                {
                    Message.Text = "Invalid Plan ID. Please enter a valid number.";
                    Message.Visible = true;
                    return;
                }

                // Create SQL connection and command
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand login_func = new SqlCommand("SELECT dbo.Wallet_Cashback_Amount(@walletID, @planID)", conn);
                    login_func.CommandType = CommandType.Text;
                    login_func.Parameters.AddWithValue("@walletID", wallet_ID);
                    login_func.Parameters.AddWithValue("@planID", plan_ID);

                    conn.Open();

                    // Execute the query and retrieve the scalar result
                    object result = login_func.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int cashback))
                    {
                        if (cashback > 0)
                        {
                            Message.Text = "Your Cashback Amount is: " + cashback + " EGP";
                        }
                        else
                        {
                            Message.Text = "No Cashback Amounts available to display.";
                        }
                    }
                    else
                    {
                        Message.Text = "No Cashback Amounts available to display.";
                    }
                    Message.Visible = true;
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