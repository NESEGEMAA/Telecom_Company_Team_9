using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Telecom_Company_Team_9
{
    public partial class MyConsumption : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridViewMyConsumption.Visible = false;
            ErrorMessageMyConsumption.Visible = false;
            Message.Visible = false;
            if (Session["UserRole"] == null || Session["UserRole"].ToString() != "Customer")
            {
                // Redirect to login or access denied page if the user is not a customer
                Response.Redirect("~/LoginCustomer.aspx");
            }
        }

        protected void Compute(object sender, EventArgs e)
        {
            string planName = PlanList.Text;
            DateTime StartDate = Calendar1.SelectedDate;
            DateTime EndDate = Calendar2.SelectedDate;
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM dbo.Consumption(@PlanName ,@StartDate, @EndDate)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@PlanName", planName);
                        cmd.Parameters.AddWithValue("@StartDate", StartDate);
                        cmd.Parameters.AddWithValue("@EndDate", EndDate);
                        if (StartDate > EndDate)
                        {
                            ErrorMessageMyConsumption.Text = "Start date is greater than the end date";
                            ErrorMessageMyConsumption.Visible = true;
                            GridViewMyConsumption.Visible = false;
                            return;
                        }

                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {

                                GridViewMyConsumption.DataSource = dt;
                                GridViewMyConsumption.DataBind();
                                GridViewMyConsumption.Visible = true;
                            }
                            else 
                            {
                                Message.Text = "No Data Found";
                                GridViewMyConsumption.Visible = false;
                                Message.Visible = true;
                                ErrorMessageMyConsumption.Visible = false;
                            }

                            }
                        }
                }
                catch (Exception ex)
                {
                    ErrorMessageMyConsumption.Text = "An error occurred: " + ex.Message;
                    ErrorMessageMyConsumption.Visible = true;
                    GridViewMyConsumption.Visible = false;
                }
            }
        }
    }
}