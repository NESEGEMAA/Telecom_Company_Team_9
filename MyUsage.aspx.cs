using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecom_Company_Team_9
{
    public partial class MyUsage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void MyUsageTable(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["TelecomeProject"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                try
                {
                    string MobileNumber = Mobileno.Text;

                    if (string.IsNullOrEmpty(MobileNumber))
                    {
                        ErrorMessageMyUsage.Text = "Mobile Number Cannot be empty";
                        return;
                    }

                    if (MobileNumber.Length < 11 || MobileNumber.Length > 11)
                    {
                        ErrorMessageMyUsage.Text = "Invalid Mobile number";
                        return;
                    }

                    con.Open();
                    string query = "SELECT * FROM dbo.Usage_Plan_CurrentMonth(@MobileNumber)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MobileNumber", MobileNumber);
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            GridViewMyUsage.DataSource = dt;
                            GridViewMyUsage.DataBind();
                        }
                    }
                }
                catch (Exception ex)
                {
                    ErrorMessageMyUsage.Text = "An error occurred: " + ex.Message;
                }
            }
        }

    }

}
}