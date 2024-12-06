using System;
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
                e.Command.Parameters["@plan"].Value = planID;
            }
            catch (Exception ex)
            {
                Label3.Text= "Invalid Plan ID";
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            SqlDataSource5.SelectCommand = "SELECT Account_Plan_date_1.* FROM dbo.Account_Plan_date(@date,@plan) AS Account_Plan_date_1" + Request.QueryString["@date"] + Request.QueryString["@plan"];
            SqlDataSource5.DataBind();
            if (GridView5.Rows.Count == 0)
            {
                Label4.Text = "No Data Found";
                Label4.Visible = true;
            }
            GridView5.Visible = true;
        }
    }
}