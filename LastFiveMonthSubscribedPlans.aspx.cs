using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Telecom_Company_Team_9
{
    public partial class LastFiveMonthSubscribedPlans : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LastFiveMonthsPlansErrorMessage2.Visible = false;
            LastFiveMonthsPlansErrorMessage.Visible = false;
            if (Session["UserRole"] == null || Session["UserRole"].ToString() != "Customer")
            {
                // Redirect to login or access denied page if the user is not a customer
                Response.Redirect("~/LoginCustomer.aspx");
            }

            // Set default mobile number and load the data
            if (!IsPostBack)
            {
                LastFiveMonthsPlansInputNumber.Text = Session["Mobile"] as string; // Set default number in the input field
                ViewLastFiveMonthsPlans(null, null); // Trigger the method to load data for the default mobile number
            }
        }

        protected void ViewLastFiveMonthsPlans(object sender, EventArgs e)
        {
            // Get the connection string from Web.config
            string connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();

            // SQL query to get data from the function
            string data = "SELECT LastFiveMonthsPlans.* FROM dbo.Subscribed_plans_5_Months (@mobileNo) AS LastFiveMonthsPlans";

            try
            {
                // Get the mobile number from the input field
                Int64 mobileNumber = Int64.Parse(LastFiveMonthsPlansInputNumber.Text);

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand cmd = new SqlCommand(data, conn))
                    {
                        // Add parameter to prevent SQL injection
                        cmd.Parameters.AddWithValue("@mobileNo", mobileNumber);

                        // Open the connection
                        conn.Open();

                        // Use SqlDataAdapter to fill the DataTable
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Check if data exists
                        if (dt.Rows.Count > 0)
                        {
                            LastFiveMonthsPlans.DataSource = dt;
                            LastFiveMonthsPlans.DataBind();
                            LastFiveMonthsPlansErrorMessage.Visible = false;
                        }
                        else
                        {
                            LastFiveMonthsPlansErrorMessage2.Text = "No plans available to display for this number.";
                            LastFiveMonthsPlansErrorMessage2.Visible = true;
                            LastFiveMonthsPlans.DataSource = null;
                            LastFiveMonthsPlans.DataBind();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LastFiveMonthsPlansErrorMessage.Text = "An error occurred: " + ex.Message;
                LastFiveMonthsPlansErrorMessage.Visible = true;
            }
        }
    }
}