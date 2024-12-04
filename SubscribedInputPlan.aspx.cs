using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecom_Company_Team_9
{
    public partial class SubscribedInputPlan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           TextBox1.Visible = true;
            Calendar1.Visible = true;
            Button6.Visible = true;
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
                Response.Write("Invalid Plan ID");
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            SqlDataSource5.SelectCommand = "SELECT Account_Plan_date_1.* FROM dbo.Account_Plan_date(@date,@plan) AS Account_Plan_date_1" + Request.QueryString["@date"] + Request.QueryString["@plan"];
            SqlDataSource5.DataBind();
            if (GridView5.Rows.Count == 0)
                Response.Write("No Data Found");
            GridView5.Visible = true;
        }
    }
}