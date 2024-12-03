using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecom_Company_Team_9
{
    public partial class AllShops : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ViewAllShops(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["NesegemaaConnection"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            String data = "SELECT * FROM allShops";
            SqlCommand cmd = new SqlCommand(data, conn);

            SqlDataAdapter reader = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            reader.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                AllShopsGridView.DataSource = dt;
                AllShopsGridView.DataBind();
                AllShopsErrorMessage.Visible = false;
            }
            else
            {
                AllShopsErrorMessage.Text = "No shops available to display.";
                AllShopsErrorMessage.Text = dt.ToString();
                AllShopsErrorMessage.Visible = true;
            }
        }
    }
}