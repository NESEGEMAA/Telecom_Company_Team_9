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
    public partial class MyCashBack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
            protected void MyCashBackTable(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["TelecomeProject"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                try
                {
                    string NationalId = NID.Text;

                    if (string.IsNullOrEmpty(NationalId))
                    {
                        ErrorMessageMyCashBack.Text = "Invalid NationalID";
                        return;
                    }
                    if (!int.TryParse(NationalId, out int nationalid))
                    {
                        ErrorMessageMyCashBack.Text = "National ID must be a valid number.";
                        return;
                    }
                    con.Open();
                    string query = "SELECT * FROM dbo.Cashback_Wallet_Customer(@NationalID)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NationalID", nationalid);
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            GridViewMyCashBack.DataSource = dt;
                            GridViewMyCashBack.DataBind();
                        }
                    }
                }
                catch (Exception ex)
                {
                    ErrorMessageMyCashBack.Text = "An error occurred: " + ex.Message;
                }
            }
        }
    }
}