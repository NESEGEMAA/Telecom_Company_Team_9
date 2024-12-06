using System;
using System.Web.UI;

namespace Telecom_Company_Team_9
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GenerateNavbar();

            // Check if the user is logged in
            if (Session["UserRole"] != null)
            {
                // Show the Logout link
                LogoutContainer.Visible = true;

                // Attach click event for Logout
                LogoutLink.ServerClick += LogoutLink_ServerClick;
            }
            else
            {
                // Hide the Logout link
                LogoutContainer.Visible = false;
            }
        }

        private void GenerateNavbar()
        {
            // Check the user's role from the session
            string role = Session["UserRole"] as string; // e.g., "Admin", "Customer", or null

            // Build the navbar HTML
            string navbarHtml = "";

            navbarHtml += "<li><a href='Home.aspx'>Home</a></li>";

            if (role == "Admin")
            {
                navbarHtml += @"
                <li><a href='ActiveAccounts.aspx'>View Active Accounts</a></li>
                <li><a href='AllResolvedTickets.aspx'>View All Resolved Tickets</a></li>
                <li><a href='PhysicalStoresVouchers.aspx'>View All Redeemed Vouchers & Stores</a></li>
                <li><a href='SubscribedServicePlans.aspx'>View All Subscribed Plans</a></li>
                <li><a href='SubscribedInputPlan.aspx'>View Input Subscribed Plans</a></li>
                <li><a href='TotalPlanUsage.aspx'>View Input Account Total Plan Usage</a></li>
                <li><a href='RemoveAllBenefits.aspx'>Remove Input Account Benefits</a></li>
                <li><a href='CashBack.aspx'>Number of Cashback per wallet</a></li>
                <li><a href='Payments_transactions.aspx'>View all payments</a></li>
                <li><a href='E-shops.aspx'>View all E-shops</a></li>
                <li><a href='AcceptedPaymentTransaction.aspx'>Accepted Payment Transaction</a></li>
                <li><a href='2.aspx'>2</a></li>
                <li><a href='3.aspx'>3</a></li>
                <li><a href='4.aspx'>4</a></li>
                <li><a href='5.aspx'>5</a></li>
                <li><a href='AllSMSOffers.aspx'>View All Input Account SMS Offers</a></li>";
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
                    <li><a href='MyCashBack.aspx'>View your Cashback transactions!</a></li>
                    <li><a href='MyConsumption.aspx'>View everyone's consumption of a certain plan ;)</a></li>
                    <li><a href='MyUsage.aspx'>View your plan usage</a></li>
                    <li><a href='UnsubscribedServices.aspx'>Checkout our other Plans</a></li>
                    <li><a href='AllServicePlans.aspx'>View all our plans</a></li>
                    <li><a href='RenewSubscription.aspx'>Renew your Subscription</a></li>";
            }

            // Links for unauthenticated users
            navbarHtml += "<li><a href='AboutUs.aspx'>About Us</a></li>";

            // Add a login/logout link at the end
            if (role == null)
            {
                navbarHtml += "<li><a href='LoginCustomer.aspx'>Log In as a Customer</a></li>";
                navbarHtml += "<li><a href='LoginAdmin.aspx'>Log In as a Admin</a></li>";
            }

            // Inject the HTML into the placeholder
            navMenuPlaceholder.Text = navbarHtml;
        }

        // Handle the Logout logic
        private void LogoutLink_ServerClick(object sender, EventArgs e)
        {
            // Clear the session
            Session.Clear(); // Removes all keys and values
            Session.Abandon(); // Ends the session

            // Optionally clear cookies
            if (Request.Cookies["ASP.NET_SessionId"] != null)
            {
                Response.Cookies["ASP.NET_SessionId"].Expires = DateTime.Now.AddDays(-1);
            }

            // Redirect the user to the login page
            Response.Redirect("Home.aspx");
        }
    }
}