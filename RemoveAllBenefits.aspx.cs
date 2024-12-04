using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Telecom_Company_Team_9
{
    public partial class RemoveAllBenefits : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox2.Visible = true;
            TextBox3.Visible = true;
            Button7.Visible = true;
        }

        protected void ExecuteStoredProcedure(String mobile, int PlanID)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("Benefits_Account", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MobileNo", mobile);
                        cmd.Parameters.AddWithValue("@PlanID", PlanID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"ID: {reader["Id"]}, Name: {reader["Name"]}");
                            }
                        }
                        if (cmd.ExecuteNonQuery() != 0)
                            Response.Write("Benefits Deleted Successfully!");
                        else
                            Response.Write("No Benefits Found");
                    }
                }
                catch (Exception ex)
                {
                    Response.Write($"Error: {ex.Message}");
                }
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                String mobile = TextBox2.Text;
                int mobileTest = int.Parse(mobile);
                int planID = int.Parse(TextBox3.Text);
                ExecuteStoredProcedure(mobile, planID);
            }
            catch (Exception ex)
            {  
                Response.Write("Invalid Plan ID or Mobile Number");
            }
        }
    }
}