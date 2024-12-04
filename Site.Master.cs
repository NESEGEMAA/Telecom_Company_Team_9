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
                    <li><a href='ViewAllBenefits.aspx'>All Active Benefits</a></li>
                    <li><a href='ViewNonResolvedTickets.aspx'>All Non Resolved Tickets</a></li>
                    <li><a href='HighestVoucherID.aspx'>Check your highest voucher</a></li>
                    <li><a href='RemainingBalance.aspx'>Remaining amount to pay for plan</a></li>
                    <li><a href='ExtraBalance.aspx'>Extra amount paid for plan</a></li>
                    <li><a href='Top10Payments.aspx'>Your Top 10 Payments</a></li>
                    <li><a href='AllShops.aspx'>All Shops</a></li>
                    <li><a href='CashbackCalculator.aspx'>Cashback Calculator</a></li>
                    <li><a href='LastFiveMonthSubscribedPlans.aspx'>Recent plans</a></li>
                    <li><a href='RechargeBalance.aspx'>Recharge Balance</a></li>
                    <li><a href='RedeemVoucher.aspx'>Redeem a Voucher</a></li>
                    <li><a href='RenewSubscription.aspx'>Renew your Subscription</a></li>";
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