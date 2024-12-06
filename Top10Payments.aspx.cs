using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Telecom_Company_Team_9
{
    public partial class Top10Payments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserRole"] == null || Session["UserRole"].ToString() != "Customer")
            {
                // Redirect to login or access denied page if the user is not a customer
                Response.Redirect("~/LoginCustomer.aspx");
            }
        }

        //Method to check if input is a number only
        public bool AreDigitsOnly(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return false;
            foreach (char character in text)
            {
                if (character < '0' || character > '9')
                    return false;
            }
            return true;
        }

        //Part 6 Component 2
        protected void PaymentView(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String mobile = mob.Text;

            SqlCommand payment_func = new SqlCommand("Top_Successful_Payments", conn);
            payment_func.CommandType = CommandType.StoredProcedure;
            payment_func.Parameters.Add(new SqlParameter("@mobile_num", mobile));
            conn.Open();

            if (string.IsNullOrEmpty(mobile) || mobile.Length != 11 || !AreDigitsOnly(mobile))
            {
                GridViewPayment.Visible = false;
                LabelPayment.Visible = true;
                LabelPayment.Text = "Please insert a valid mobile number";
                return;
            }

            SqlDataAdapter reader = new SqlDataAdapter(payment_func);
            DataTable dt = new DataTable();
            reader.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                GridViewPayment.Visible = false;
                LabelPayment.Visible = true;
                LabelPayment.Text = "No data found for the given Mobile Number.";
            }
            else
            {
                LabelPayment.Visible = false;
                GridViewPayment.Visible = true;
                GridViewPayment.DataSource = dt;
                GridViewPayment.DataBind();
            }
        }
    }
}