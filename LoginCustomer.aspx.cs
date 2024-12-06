using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;

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
                            Session["UserRole"] = "Customer";
                            Session["Mobile"] = mobile_num;

                            string query2 = "SELECT nationalID FROM customer_account WHERE mobileNo = @mobileNo";
                            SqlCommand cmd2 = new SqlCommand(query2, con);
                            cmd2.Parameters.Add(new SqlParameter("@mobileNo", mobile_num));

                            object result2 = cmd2.ExecuteScalar();  // Execute the query and fetch the first result (National ID)

                            if (result2 != null)
                            {
                                Session["NID"] = result2.ToString();
                                Console.Write(result2);
                            }

                            Response.Redirect("Home.aspx");
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