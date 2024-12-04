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
    public partial class HighestVoucherID : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

        //Part 3 Component 2
        protected void ViewVoucher(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
            String mobile = mobi.Text;
            SqlCommand voucher_func = new SqlCommand("Account_Highest_Voucher", conn);
            voucher_func.CommandType = CommandType.StoredProcedure;
            voucher_func.Parameters.Add(new SqlParameter("@mobile_num", mobile));

            conn.Open();
            SqlDataReader reader = voucher_func.ExecuteReader();

            if (String.IsNullOrEmpty(mobile) || mobile.Length != 11 || !AreDigitsOnly(mobile))
            {
                LabelVoucher.Visible = true;
                LabelVoucher.Text = "Please insert a valid mobile number";
            }
            else
            {
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
            conn.Close();


        }
    }
}