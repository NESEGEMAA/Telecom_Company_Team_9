﻿using System;

namespace Telecom_Company_Team_9
{
    public partial class PhysicalStoresVouchers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserRole"] == null || Session["UserRole"].ToString() != "Admin")
            {
                // Redirect to login or access denied page if the user is not an admin
                Response.Redirect("~/LoginAdmin.aspx");
            }
            else
            {
                GridView2.Visible = true;
            }
        }
    }
}