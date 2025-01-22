using System;
using System.Data;
using System.Web.UI.WebControls;

namespace Telecom_Company_Team_9
{
    public partial class SubscribedInputPlan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserRole"] == null || Session["UserRole"].ToString() != "Admin")
            {
                // Redirect to login or access denied page if the user is not an admin
                Response.Redirect("~/LoginAdmin.aspx");
            }

            TextBox1.Visible = true;
            Calendar1.Visible = true;
            Button6.Visible = true;
            Label3.Visible = false;
            Label4.Visible = false;
        }

        protected void OnMyDataSourceSelecting1(object sender, SqlDataSourceSelectingEventArgs e)
        {
            try
            {
                Int32 planID = int.Parse(TextBox1.Text);
                DateTime dateTime = Calendar1.SelectedDate;
                e.Command.Parameters["@date"].Value = dateTime;
                e.Command.Parameters["@Plan_id"].Value = planID;
            }
            catch (Exception ex)
            {
                Label3.Text= "Invalid Plan ID";
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrEmpty(TextBox1.Text))
            {
                Label4.Text = "Please select a valid date and enter a valid Plan ID.";
                Label4.Visible = true;
                GridView5.Visible = false;
                return;
            }

            // Retrieve inputs
            string subscriptionDate = Calendar1.SelectedDate.ToString("yyyy-MM-dd");
            string planId = TextBox1.Text.Trim();

            // Clear previous parameters and set new ones
            SqlDataSource5.SelectParameters.Clear();
            SqlDataSource5.SelectCommand = "SELECT Account_Plan_date_1.* FROM dbo.Account_Plan_date(@Subscription_Date, @Plan_id) AS Account_Plan_date_1";
            SqlDataSource5.SelectParameters.Add("Subscription_Date", subscriptionDate);
            SqlDataSource5.SelectParameters.Add("Plan_id", planId);

            try
            {
                // Bind data
                SqlDataSource5.DataBind();

                // Check if data exists
                if (GridView5.Rows.Count == 0)
                {
                    Label4.Text = "No Data Found";
                    Label4.Visible = true;
                    GridView5.Visible = false;
                }
                else
                {
                    Label4.Visible = false;
                    GridView5.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Label4.Text = "An error occurred: " + ex.Message;
                Label4.Visible = true;
                GridView5.Visible = false;
            }
        }

    }
}