using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Telecom_Company_Team_9
{
    public partial class RemainingBalance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelRem2.Visible = false;
            LabelRem.Visible = false;
            if (Session["UserRole"] == null || Session["UserRole"].ToString() != "Customer")
            {
                // Redirect to login or access denied page if the user is not a customer
                Response.Redirect("~/LoginCustomer.aspx");
            }

            if (!IsPostBack)
            {
                mobileNumR.Text = Session["Mobile"] as string;
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

        //Part 4
        protected void ViewRemainingAmount(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String mob = mobileNumR.Text;
            String plan_name = plannameR.Text;

            SqlCommand Check_amount = new SqlCommand("Remaining_plan_amount", conn);
            Check_amount.CommandText = "SELECT dbo.Remaining_plan_amount(@mobile_num, @plan_name)";
            Check_amount.CommandType = CommandType.Text;
            Check_amount.Parameters.Add(new SqlParameter("@mobile_num", mob));
            Check_amount.Parameters.Add(new SqlParameter("@plan_name", plan_name));

            conn.Open();
            if (String.IsNullOrEmpty(mob) || String.IsNullOrEmpty(plan_name) || mob.Length != 11 || !AreDigitsOnly(mob))
            {
                LabelRem.Text = "Please insert a valid mobile number and plan name";
                LabelRem.Visible = true;

                return;
            }
            Check_amount.ExecuteNonQuery();
            int amount = (int)Check_amount.ExecuteScalar();

            if (amount > 0)
            {
                LabelRem2.Text = "The remaining amount is: " + amount;
                LabelRem2.Visible = true;
            }
            else
            {
                LabelRem2.Text = "There is no remaining balance for this account";
                LabelRem2.Visible = true;

            }
            conn.Close();
        }
    }
}