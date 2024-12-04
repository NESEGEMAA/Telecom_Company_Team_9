using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecom_Company_Team_9
{
    public partial class LoginCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login(object sender, EventArgs e)
        {
            string mobile_num = MobileNumber.Text;
            string password = Password.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                try
                {

                    con.Open();
                    string query = "SELECT dbo.AccountLoginValidation(@MobileNo, @Password)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MobileNo", mobile_num);
                        cmd.Parameters.AddWithValue("@Password", password);
                        bool result = (bool)cmd.ExecuteScalar();
                        if (result)
                        {
                            Response.Redirect("Dashboard.aspx");
                        }
                        else
                        {
                            ErrorMessage.Text = "Invalid mobile number or password. Please try again.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    ErrorMessage.Text = "An error occurred: " + ex.Message;
                }
            }
        }
    }
}