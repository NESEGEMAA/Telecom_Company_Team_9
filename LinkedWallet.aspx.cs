using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;

namespace Telecom_Company_Team_9
{
    public partial class LinkedWallet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserRole"] == null || Session["UserRole"].ToString() != "Admin")
            {
                // Redirect to login or access denied page if the user is not an admin
                Response.Redirect("~/LoginAdmin.aspx");
            }
        }

        protected void RetrieveCashbackButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the connection string from Web.config
                string connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                String mob = InputNumber.Text;
                SqlCommand login_func = new SqlCommand("Wallet_MobileNo", conn);
                login_func.CommandText = "SELECT dbo.Wallet_MobileNo(@MobileNo)";
                login_func.CommandType = CommandType.Text;
                login_func.Parameters.Add(new SqlParameter("@MobileNo", mob));


                conn.Open();
                login_func.ExecuteNonQuery();
                Boolean success = (bool)login_func.ExecuteScalar();

                /* hardcoded parameters */

                if (success == true)
                {
                    Message.Text = "There is a wallet associated to this mobile number";
                    Message.Visible = true;
                }
                else
                {
                    Message.Text = "There is no wallet associated to this mobile number";
                    Message.Visible = true;  // Show the error message
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
