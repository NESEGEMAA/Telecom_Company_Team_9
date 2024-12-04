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
    public partial class DashBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void AllServicePlans(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["TelecomeProject"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                try
                {

                    con.Open();
                    string query = "SELECT * FROM [allServicePlans]";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            GridViewAlLServices.DataSource = dt;
                            GridViewAlLServices.DataBind();
                        }
                    }
                }
                catch (Exception ex)
                {
                    ErrorMessageAllServices.Text = "An error occurred: " + ex.Message;
                }
            }
        }
        protected void MyConsumption(object sender, EventArgs e)
        {

            try
            {
                Response.Redirect("MyConsumption.aspx");
            }
            catch (Exception ex)
            {
                ConsumeErrorMessage.Text = "An error occurred: " + ex.Message;
            }

        }
        protected void UnsubscribedServices(object sender, EventArgs e)
        {

            try
            {
                Response.Redirect("UnsubscribedServices.aspx");
            }
            catch (Exception ex)
            {
                UnsubscribedErrorMessage.Text = "An error occurred: " + ex.Message;
            }

        }
        protected void MyUsageButton(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("MyUsage.aspx");
            }
            catch (Exception ex)
            {
                MyUsageErrorMessage.Text = "An error occurred: " + ex.Message;
            }

        }
        protected void MyCashbackTransactions(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("MyCashBack.aspx");
            }
            catch (Exception ex)
            {
                CashbackErrorMessage.Text = "An error occurred: " + ex.Message;
            }

        }
    }

}
