﻿using System;
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
                BenefitErrorMessage.Visible = false;
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
        protected void ViewTickets(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
            String nationalID = NID.Text;

            SqlCommand count_func = new SqlCommand("Ticket_Account_Customer", conn);
            count_func.CommandType = CommandType.StoredProcedure;

            count_func.Parameters.Add(new SqlParameter("@NID", nationalID));

            conn.Open();
            SqlDataReader reader = count_func.ExecuteReader();

            if (reader.Read())
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

            if (reader.Read())
            {
                LabelVoucher.Text = "The ID of the highest value voucher is: " + reader["voucherID"];

            }
            else
            {
                LabelVoucher.Text = "There are no Vouchers for this Mobile Number";
            }
        }
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
        }
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
        }

        protected void PaymentView(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String mobile = mob.Text;


            SqlCommand payment_func = new SqlCommand("Top_Successful_Payments", conn);
            payment_func.CommandType = CommandType.StoredProcedure;
            payment_func.Parameters.Add(new SqlParameter("@mobile_num", mobile));
            conn.Open();
            SqlDataAdapter reader = new SqlDataAdapter(payment_func);
            DataTable dt = new DataTable();
            reader.Fill(dt);

            GridViewPayment.DataSource = dt;
            GridViewPayment.DataBind();
        }
    }
}