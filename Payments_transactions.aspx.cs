using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecom_Company_Team_9
{
    public partial class Payments_transactions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Get the connection string from Web.config
            string connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();

            // SQL query to get data from the function
            string data = "SELECT * FROM dbo.AccountPayments";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand cmd = new SqlCommand(data, conn))
                    {
                        // Open the connection
                        conn.Open();

                        SqlDataAdapter reader = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        reader.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            Payments_transactionView.DataSource = dt;
                            Payments_transactionView.DataBind();
                            Message.Visible = false;
                        }
                        else
                        {
                            Message.Text = "No payments available to display.";
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