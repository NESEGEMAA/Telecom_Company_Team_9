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
    public partial class AverageSentTransactionsAmounts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserRole"] == null || Session["UserRole"].ToString() != "Admin")
            {
                // Redirect to login or access denied page if the user is not an admin
                Response.Redirect("~/LoginAdmin.aspx");
            }
        }

        protected void RetrievePaymentsButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the connection string from Web.config
                string connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand login_func = new SqlCommand("Wallet_MobileNo", conn);
                Int32 wallet_ID = int.Parse(InputWallet.Text);
                DateTime StartDate = Calendar1.SelectedDate;
                DateTime EndDate = Calendar2.SelectedDate;
                login_func.CommandText = "SELECT dbo.Wallet_Transfer_Amount(@walletID, @start_date,@end_date)";
                login_func.CommandType = CommandType.Text;
                login_func.Parameters.Add(new SqlParameter("@walletID", wallet_ID));
                login_func.Parameters.Add(new SqlParameter("@start_date", StartDate));
                login_func.Parameters.Add(new SqlParameter("@end_date", EndDate));
                conn.Open();
                login_func.ExecuteNonQuery();
                int average = (int)login_func.ExecuteScalar();

                if (average >= 0)
                        {
                            Message.Text = "Average sent transaction amounts : " + average;
                            Message.Visible = true;
                        }
                        else
                        {
                            Message.Text = "No Transaction Amounts available to display.";
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