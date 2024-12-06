using System;
using System.Web.Services.Description;
using System.Web.UI.WebControls;

namespace Telecom_Company_Team_9
{
    public partial class PhysicalStoresVouchers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Visible = false;
            GridView2.Visible = false;
            if (Session["UserRole"] == null || Session["UserRole"].ToString() != "Admin")
            {
                // Redirect to login or access denied page if the user is not an admin
                Response.Redirect("~/LoginAdmin.aspx");
            }
            else
            {
                if (GridView2.Rows.Count != 0)
                    GridView2.Visible = true;
                else
                {
                    Message.Text = "No Data Found";
                    Message.Visible = true;
                }

            }
        }
    }
}