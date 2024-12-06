using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Telecom_Company_Team_9
{
    public partial class MyCashBack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserRole"] == null || Session["UserRole"].ToString() != "Customer")
            {
                // Redirect to login or access denied page if the user is not a customer
                Response.Redirect("~/LoginCustomer.aspx");
            }
        }

        protected void MyCashBackTable(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string NationalId = NID.Text;

                if (string.IsNullOrEmpty(NationalId))
                {
                    ErrorMessageMyCashBack.Text = "Invalid NationalID";
                    ErrorMessageMyCashBack.Visible = true;

                    // Removing previously output table
                    GridViewMyCashBack.DataSource = null;
                    GridViewMyCashBack.DataBind();
                }
                else if (!int.TryParse(NationalId, out int nationalid))
                {
                    ErrorMessageMyCashBack.Text = "National ID must be a valid number.";
                    ErrorMessageMyCashBack.Visible = true;

                    // Removing previously output table
                    GridViewMyCashBack.DataSource = null;
                    GridViewMyCashBack.DataBind();
                }
                else
                {
                    try
                    {
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
                                ErrorMessageMyCashBack.Visible = false;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        ErrorMessageMyCashBack.Text = "An error occurred: " + ex.Message;
                        ErrorMessageMyCashBack.Visible = true;
                    }
                }
            }
        }
    }
}