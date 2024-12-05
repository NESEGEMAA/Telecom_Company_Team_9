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
        }

        protected void Compute(object sender, EventArgs e)
        {
            string planName = PlanList.Text;
            DateTime StartDate = Start.SelectedDate;
            DateTime EndDate = End.SelectedDate;
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
                            return;
                        }

                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            GridViewMyConsumption.DataSource = dt;
                            GridViewMyConsumption.DataBind();
                        }
                    }
                }
                catch (Exception ex)
                {
                    ErrorMessageMyConsumption.Text = "An error occurred: " + ex.Message;
                }
            }
        }
    }
}