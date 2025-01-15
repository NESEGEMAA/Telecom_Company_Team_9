using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Telecom_Company_Team_9
{
    public partial class MyUsage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
            ErrorMessageMyUsage.Visible = false;
            if (Session["UserRole"] == null || Session["UserRole"].ToString() != "Customer")
            {
                // Redirect to login or access denied page if the user is not a customer
                Response.Redirect("~/LoginCustomer.aspx");
            }

            // Set default Mobile Number and load usage data
            if (!IsPostBack)
            {
                Mobileno.Text = Session["Mobile"] as string;
                MyUsageTable(null, null); // Trigger the method to load usage data for the default mobile number
            }
        }

        protected void MyUsageTable(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string MobileNumber = Mobileno.Text;

                    // Validation for Mobile Number input
                    if (string.IsNullOrEmpty(MobileNumber))
                    {
                        ErrorMessageMyUsage.Text = "Mobile Number Cannot be empty";
                        ErrorMessageMyUsage.Visible = true;
                        GridViewMyUsage.Visible = false;
                        return;
                    }

                    if (MobileNumber.Length != 11) // Mobile number must be exactly 11 digits
                    {
                        ErrorMessageMyUsage.Text = "Invalid Mobile number";
                        ErrorMessageMyUsage.Visible = true;
                        GridViewMyUsage.Visible = false;
                        return;
                    }

                    con.Open();
                    string query = "SELECT * FROM dbo.Usage_Plan_CurrentMonth(@MobileNo)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MobileNo", MobileNumber);
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                GridViewMyUsage.DataSource = dt;
                                GridViewMyUsage.DataBind();
                                GridViewMyUsage.Visible = true;
                                ErrorMessageMyUsage.Visible = false;
                            }
                            else
                            {
                                GridViewMyUsage.Visible=false;
                                Label1.Text = "No Data Found";
                                Label1.Visible = true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    ErrorMessageMyUsage.Text = "An error occurred: " + ex.Message;
                    ErrorMessageMyUsage.Visible = true;
                    GridViewMyUsage.Visible = false;
                }
            }
        }
    }
}
