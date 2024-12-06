﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Telecom_Company_Team_9
{
    public partial class RemoveAllBenefits : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserRole"] == null || Session["UserRole"].ToString() != "Admin")
            {
                // Redirect to login or access denied page if the user is not an admin
                Response.Redirect("~/LoginAdmin.aspx");
            }
            Message.Visible = false;
            TextBox2.Visible = true;
            TextBox3.Visible = true;
            Button7.Visible = true;
        }

        protected void ExecuteStoredProcedure(Int64 mobile, int PlanID)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("Benefits_Account", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@mobile_num", mobile);
                        cmd.Parameters.AddWithValue("@plan_id", PlanID);
                        if (cmd.ExecuteNonQuery() != 0)
                            Message.Text = "Benefits Deleted Successfully!";
                        else
                            Message.Text = ("No Benefits Found");
                    }
                }
                catch (Exception ex)
                {
                    Message.Text = ($"Error: {ex.Message}");
                }
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                String mobile = TextBox2.Text;
                int mobileTest = int.Parse(mobile);
                int planID = int.Parse(TextBox3.Text);
                ExecuteStoredProcedure(mobileTest, planID);
            }
            catch (Exception ex)
            {  
                Message.Text = ("Invalid Plan ID or Mobile Number");
            }
        }
    }
}