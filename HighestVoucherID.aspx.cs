using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Telecom_Company_Team_9
{
    public partial class HighestVoucherID : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserRole"] == null || Session["UserRole"].ToString() != "Customer")
            {
                // Redirect to login or access denied page if the user is not a customer
                Response.Redirect("~/LoginCustomer.aspx");
            }

            // Only execute on the first page load, not on postback
            if (!IsPostBack)
            {
                string defaultMobile = Session["Mobile"] as string; // Default mobile number
                DisplayVoucher(defaultMobile);
            }
        }

        // Method to check if input is a number only
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

        // Reusable method to query and display voucher information
        private void DisplayVoucher(string mobile)
        {
            if (string.IsNullOrEmpty(mobile) || mobile.Length != 11 || !AreDigitsOnly(mobile))
            {
                LabelVoucher.Visible = true;
                LabelVoucher.Text = "Please insert a valid mobile number";
                return;
            }

            string connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand voucherFunc = new SqlCommand("Account_Highest_Voucher", conn);
                voucherFunc.CommandType = CommandType.StoredProcedure;
                voucherFunc.Parameters.Add(new SqlParameter("@mobile_num", mobile));

                try
                {
                    conn.Open();
                    SqlDataReader reader = voucherFunc.ExecuteReader();

                    if (reader.Read())
                    {
                        LabelVoucher.Visible = true;
                        LabelVoucher.Text = "The ID of the highest value voucher is: " + reader["voucherID"];
                    }
                    else
                    {
                        LabelVoucher.Visible = true;
                        LabelVoucher.Text = "There are no Vouchers for this Mobile Number";
                    }
                }
                catch (Exception ex)
                {
                    LabelVoucher.Visible = true;
                    LabelVoucher.Text = "An error occurred: " + ex.Message;
                }
            }
        }

        // Button click event to handle user input
        protected void ViewVoucher(object sender, EventArgs e)
        {
            string mobile = mobi.Text;
            DisplayVoucher(mobile);
        }
    }
}
