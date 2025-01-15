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
            // Retrieve connection string
            String connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();
            String mob = mobileNumR.Text;
            String plan_name = plannameR.Text;

            // Validate input
            if (String.IsNullOrEmpty(mob) || String.IsNullOrEmpty(plan_name) || mob.Length != 11 || !AreDigitsOnly(mob))
            {
                LabelRem.Text = "Please insert a valid mobile number and plan name";
                LabelRem.Visible = true;
                return;
            }

            // Database interaction
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand checkAmount = new SqlCommand("SELECT dbo.Remaining_plan_amount(@mobile_num, @plan_name)", conn))
                {
                    checkAmount.CommandType = CommandType.Text;
                    checkAmount.Parameters.Add(new SqlParameter("@mobile_num", mob));
                    checkAmount.Parameters.Add(new SqlParameter("@plan_name", plan_name));

                    try
                    {
                        conn.Open();

                        // Use ExecuteScalar to retrieve a single scalar value
                        object result = checkAmount.ExecuteScalar();

                        if (result != null && decimal.TryParse(result.ToString(), out decimal amount))
                        {
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
                        }
                        else
                        {
                            LabelRem2.Text = "An error occurred or no result found.";
                            LabelRem2.Visible = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        LabelRem.Text = "An error occurred: " + ex.Message;
                        LabelRem.Visible = true;
                    }
                }
            }
        }
    }
}