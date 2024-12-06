using System;
using System.Web.UI.WebControls;

namespace Telecom_Company_Team_9
{
    public partial class SubscribedServicePlans : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView4.Visible = false;
            if (Session["UserRole"] == null || Session["UserRole"].ToString() != "Admin")
            {
                // Redirect to login or access denied page if the user is not an admin
                Response.Redirect("~/LoginAdmin.aspx");
            }
            else
            {
                if (GridView4.Rows.Count != 0)
                    GridView4.Visible = true;
                else
                    Message.Text = "No Data Found";
            }
        }

        protected void GridView4_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                // Loop through all cells in the row
                for (int i = 0; i < e.Row.Cells.Count; i++)
                {
                    // Add a custom attribute (data-label) to each cell
                    e.Row.Cells[i].Attributes["data-label"] = e.Row.Cells[i].Text;
                }
            }
        }

    }
}