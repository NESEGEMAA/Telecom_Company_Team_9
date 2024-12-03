using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecom_Company_Team_9
{
    public partial class CustomerComponent2 : System.Web.UI.Page
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
        //Part 1
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
                BenefitErrorMessage.Visible = true;


            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Part 2
        protected void ViewTickets(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
            String nationalID = NID.Text;

            SqlCommand count_func = new SqlCommand("Ticket_Account_Customer", conn);
            count_func.CommandType = CommandType.StoredProcedure;

            count_func.Parameters.Add(new SqlParameter("@NID", nationalID));

            conn.Open();
            if (!AreDigitsOnly(nationalID))
            {
                lblTicketCount.Text = "Please insert a valid National ID";
                return;
            }

            if (!int.TryParse(nationalID, out _))
            {
                lblTicketCount.Text = "Error: National ID must be a valid integer and within the range of 0 to 2,147,483,647.";
                return;
            }
            SqlDataReader reader = count_func.ExecuteReader();

            
                if(reader.Read())
            {
                int ticketCount = Convert.ToInt32(reader["Count"]);
                if (ticketCount > 0)
                {

                    lblTicketCount.Text = "Number of Unresolved Tickets:  " + reader["Count"];
                }

                else
                {

                    lblTicketCount.Text = "No data found for the given National ID.";
                }

            }

            else
            {
                lblTicketCount.Text = "No data found for the given National ID.";
            }

            

            conn.Close();

        }


           
        

        //Part 3
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
            if(String.IsNullOrEmpty(mob) || String.IsNullOrEmpty(plan_name) || mob.Length != 11 || !AreDigitsOnly(mob))
            {
                LabelRem.Text = "Please insert a valid mobile number and plan name";
                return;
            }
            Check_amount.ExecuteNonQuery();
            int amount = (int)Check_amount.ExecuteScalar();
            conn.Close();


            if (amount > 0)
            {
                LabelRem.Text = "The remaining amount is: " + amount;

            }
            else
            {
                LabelRem.Text = "There is no remaining balance for this account";
            }
            conn.Close();
        }

        //Part 5
        protected void ViewExtraAmount(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String mob = mobileNumE.Text;
            String plan_name = plannameE.Text;

            SqlCommand Check_amount = new SqlCommand("Extra_plan_amount", conn);
            Check_amount.CommandText = "SELECT dbo.Extra_plan_amount(@mobile_num, @plan_name)";
            Check_amount.CommandType = CommandType.Text;
            Check_amount.Parameters.Add(new SqlParameter("@mobile_num", mob));
            Check_amount.Parameters.Add(new SqlParameter("@plan_name", plan_name));

            conn.Open();
            if (String.IsNullOrEmpty(mob) || String.IsNullOrEmpty(plan_name) || mob.Length != 11 || !AreDigitsOnly(mob))
            {
                LabelExt.Text = "Please insert a valid mobile number and plan name";
                return;
            }

            Check_amount.ExecuteNonQuery();
            int amount = (int)Check_amount.ExecuteScalar();
            conn.Close();


            if (amount > 0)
            {
                LabelExt.Text = "The extra amount is: " + amount;

            }
            else
            {
                LabelExt.Text = "There is no extra balance for this account";
            }
            conn.Close();
        }


        //Part 6
        protected void PaymentView(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String mobile = mob.Text;


            SqlCommand payment_func = new SqlCommand("Top_Successful_Payments", conn);
            payment_func.CommandType = CommandType.StoredProcedure;
            payment_func.Parameters.Add(new SqlParameter("@mobile_num", mobile));
            conn.Open();

            if(string.IsNullOrEmpty(mobile) || mobile.Length != 11 || !AreDigitsOnly(mobile))
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