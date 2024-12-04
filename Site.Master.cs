using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecom_Company_Team_9
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GenerateNavbar();
            }
        }

        private void GenerateNavbar()
        {
            // Check the user's role from the session
            string role = Session["UserRole"] as string; // e.g., "Admin", "Customer", or null

            // Build the navbar HTML
            string navbarHtml = "<ul>";

            if (role == "Admin")
            {
                navbarHtml += @"
                <li><a href='AdminDashboard.aspx'>Admin Dashboard</a></li>
                <li><a href='ManageUsers.aspx'>Manage Users</a></li>
                <li><a href='Reports.aspx'>Reports</a></li>";
            }
            else if (role == "Customer")
            {
                navbarHtml += @"
                <li><a href='CustomerProfile.aspx'>My Profile</a></li>
                <li><a href='ViewPlans.aspx'>View Plans</a></li>
                <li><a href='Recharge.aspx'>Recharge</a></li>";
            }

            // Links for unauthenticated users
            navbarHtml += @"
                <li><a href='AboutUs.aspx'>About Us</a></li>
                <li><a href='Contact.aspx'>Contact</a></li>";

            // Add a login/logout link at the end
            if (role == null)
            {
                navbarHtml += "<li><a href='Login.aspx'>Log In</a></li>";
            }
            else
            {
                navbarHtml += "<li><a href='Logout.aspx'>Log Out</a></li>";
            }

            navbarHtml += "</ul>";

            // Inject the HTML into the placeholder
            navMenuPlaceholder.Text = navbarHtml;
        }

    }
}