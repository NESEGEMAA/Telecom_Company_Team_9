using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Telecom_Company_Team_9
{
    public partial class CustomerWallets : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Visible = false;
            if (Session["UserRole"] == null || Session["UserRole"].ToString() != "Admin")
            {
                // Redirect to login or access denied page if the user is not an admin
                Response.Redirect("~/LoginAdmin.aspx");
            }

            // Get the connection string from Web.config
            string connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();

            // SQL query to get data from the function
            string data = "SELECT * FROM dbo.CustomerWallet";

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
                            CustomerWalletView.DataSource = dt;
                            CustomerWalletView.DataBind();
                            Message.Visible = false;
                        }
                        else
                        {
                            Message.Text = "No Customers available to display.";
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