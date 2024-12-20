﻿using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Telecom_Company_Team_9
{
    public partial class DashBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ErrorMessageAllServices.Visible = false;
            if (Session["UserRole"] == null || Session["UserRole"].ToString() != "Customer")
            {
                // Redirect to login or access denied page if the user is not a customer
                Response.Redirect("~/LoginCustomer.aspx");
            }

            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM [allServicePlans]";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            GridViewAlLServices.DataSource = dt;
                            GridViewAlLServices.DataBind();
                        }
                    }
                }
                catch (Exception ex)
                {
                    ErrorMessageAllServices.Text = "An error occurred: " + ex.Message;
                }
            }
        }
    
    }

        
}