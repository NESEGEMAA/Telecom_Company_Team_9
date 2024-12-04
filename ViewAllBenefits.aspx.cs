using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Telecom_Company_Team_9
{
    public partial class ViewAllBenefits : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        //Part 1 Component 2
        protected void ViewBenefits(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            String data = "SELECT * FROM allBenefits";
            SqlCommand cmd = new SqlCommand(data, conn);

            SqlDataAdapter reader = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            reader.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                GridBenefitView.DataSource = dt;
                GridBenefitView.DataBind();
            }
            else
            {
                BenefitErrorMessage.Text = "No benefits available to display.";
            }
            conn.Close();
        }
    }
}