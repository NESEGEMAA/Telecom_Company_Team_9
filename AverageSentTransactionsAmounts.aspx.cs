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
            Message.Visible = false;
            Message2.Visible = false;
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

                Int32 wallet_ID = int.Parse(InputWallet.Text);
                DateTime StartDate = Calendar1.SelectedDate;
                DateTime EndDate = Calendar2.SelectedDate;

                SqlCommand login_func = new SqlCommand("SELECT dbo.Wallet_Transfer_Amount(@walletID, @start_date, @end_date)", conn);
                login_func.CommandType = CommandType.Text;

                // Add parameters to the query
                login_func.Parameters.Add(new SqlParameter("@walletID", wallet_ID));
                login_func.Parameters.Add(new SqlParameter("@start_date", StartDate));
                login_func.Parameters.Add(new SqlParameter("@end_date", EndDate));

                // Open connection and execute the query
                conn.Open();
                object result = login_func.ExecuteScalar();

                // Check if the result is not null and cast it to an int
                if (result != null && result != DBNull.Value)
                {
                    int average = Convert.ToInt32(result);  // safely cast result to int

                    if (average >= 0)
                    {
                        Message2.Text = "Average sent transaction amounts: " + average;
                    }
                    else
                    {
                        Message2.Text = "No Transaction Amounts available to display.";
                    }
                }
                else
                {
                    Message2.Text = "No Transaction Amounts available to display.";
                }
                Message2.Visible = true;
                Message.Visible = false;
            }
            catch (Exception ex)
            {
                Message.Text = "An error occurred: " + ex.Message;
                Message.Visible = true;
            }
        }
    }
}