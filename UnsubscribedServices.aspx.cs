﻿using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Telecom_Company_Team_9
{
    public partial class UnsubscribedServices : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserRole"] == null || Session["UserRole"].ToString() != "Customer")
            {
                // Redirect to login or access denied page if the user is not a customer
                Response.Redirect("~/LoginCustomer.aspx");
            }

            // Set default Mobile Number and load usage data
            if (!IsPostBack)
            {
                Mobileno.Text = Session["Mobile"] as string;
                UnsubscribedTable(null, null); // Trigger the method to load usage data for the default mobile number
            }
        }

        protected void UnsubscribedTable(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    String MobileNumber = Mobileno.Text;

                    if (string.IsNullOrEmpty(MobileNumber))
                    {
                        ErrorMessageUnsubscribtion.Text = "Mobile Number Cannot be empty";
                        return;
                    }

                    if (MobileNumber.Length < 11 || MobileNumber.Length > 11)
                    {
                        ErrorMessageUnsubscribtion.Text = "Invalid Mobile number";
                        return;
                    }

                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("Unsubscribed_Plans", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@mobile_num", MobileNumber);
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            GridViewUnsubscribedPlans.DataSource = dt;
                            GridViewUnsubscribedPlans.DataBind();
                        }
                    }
                }
                catch (Exception ex)
                {
                    ErrorMessageUnsubscribtion.Text = "An error occurred: " + ex.Message;
                }
            }
        }
    }
}