using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Telecom_Company_Team_9
{
    public partial class ExtraBalance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelExt.Visible = false;
            LabelExt2.Visible = false;

            if (Session["UserRole"] == null || Session["UserRole"].ToString() != "Customer")
            {
                // Redirect to login or access denied page if the user is not a customer
                Response.Redirect("~/LoginCustomer.aspx");
            }

            if (!IsPostBack)
            {
                mobileNumE.Text = Session["Mobile"] as string;
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

        //Part 5 Component 2
        protected void ViewExtraAmount(object sender, EventArgs e)
        {
            // Retrieve the connection string
            String connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();
            String mob = mobileNumE.Text.Trim();
            String plan_name = plannameE.Text.Trim();

            // Validate input
            if (String.IsNullOrEmpty(mob) || String.IsNullOrEmpty(plan_name) || mob.Length != 11 || !AreDigitsOnly(mob))
            {
                LabelExt2.Text = "Please insert a valid mobile number and plan name";
                LabelExt2.Visible = true;
                return;
            }

            // Database interaction
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand checkAmount = new SqlCommand("SELECT dbo.Extra_plan_amount(@mobile_num, @plan_name)", conn))
                {
                    checkAmount.CommandType = CommandType.Text;
                    checkAmount.Parameters.Add(new SqlParameter("@mobile_num", mob));
                    checkAmount.Parameters.Add(new SqlParameter("@plan_name", plan_name));

                    try
                    {
                        conn.Open();

                        // ExecuteScalar to retrieve the extra amount
                        object result = checkAmount.ExecuteScalar();

                        if (result != null && decimal.TryParse(result.ToString(), out decimal amount))
                        {
                            if (amount > 0)
                            {
                                LabelExt.Text = "The extra amount is: " + amount;
                            }
                            else
                            {
                                LabelExt.Text = "There is no extra balance for this account";
                            }
                        }
                        else
                        {
                            LabelExt.Text = "An error occurred or no result found.";
                        }

                        LabelExt.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        LabelExt2.Text = "An error occurred: " + ex.Message;
                        LabelExt2.Visible = true;
                    }
                }
            }
        }

    }
}