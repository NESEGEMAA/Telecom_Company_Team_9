﻿using System;
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
    public partial class RemainingBalance : System.Web.UI.Page
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
                return;
            }
            Check_amount.ExecuteNonQuery();
            int amount = (int)Check_amount.ExecuteScalar();



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
    }
}