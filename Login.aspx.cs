﻿using System;
using System.Collections.Generic;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecom_Company_Team_9
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void login(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String mob = mobile.Text;
            String pass = password.Text;

            SqlCommand login_func = new SqlCommand("AccountLoginValidation", conn);
            login_func.CommandText = "SELECT dbo.AccountLoginValidation(@MobileNo, @password)";
            login_func.CommandType = CommandType.Text;
            login_func.Parameters.Add(new SqlParameter("@MobileNo", mob));
            login_func.Parameters.Add(new SqlParameter("@password", pass));

            conn.Open();
            login_func.ExecuteNonQuery();
            Boolean success = (bool)login_func.ExecuteScalar();
            conn.Close();

            if (success == false)
            {
                Session["admin"] = mob;
                Response.Redirect("admin_view.aspx");
            }
            else
            {
                Response.Redirect("customer_view.aspx");

            }
        }
    }
}