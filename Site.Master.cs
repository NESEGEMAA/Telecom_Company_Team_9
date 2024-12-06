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

            // Common Home link
            navbarHtml += "<li><a href='Home.aspx'><i class='fas fa-home'></i> Home</a></li>";

            if (role == "Admin")
            {
                navbarHtml += @"
        <li><a href='ActiveAccounts.aspx'><i class='fas fa-user-check'></i> View All Active Accounts</a></li>
        <li><a href='AllResolvedTickets.aspx'><i class='fas fa-check-circle'></i> View All Resolved Tickets</a></li>
        <li><a href='SubscribedServicePlans.aspx'><i class='fas fa-layer-group'></i> View All Subscribed Plans</a></li>
        <li><a href='Payments_transactions.aspx'><i class='fas fa-dollar-sign'></i> View All Payments</a></li>
        <li><a href='E-shops.aspx'><i class='fas fa-store'></i> View All E-shops</a></li>
        <li><a href='PhysicalStoresVouchers.aspx'><i class='fas fa-receipt'></i> Redeemed Vouchers & Stores</a></li>
        <li><a href='CashBack.aspx'><i class='fas fa-wallet'></i> Wallet Cashback Transactions</a></li>
        <li><a href='AcceptedPaymentTransaction.aspx'><i class='fas fa-money-check-alt'></i> Input Account Payment & Points</a></li>
        <li><a href='SubscribedInputPlan.aspx'><i class='fas fa-clipboard'></i> Input Subscribed Plans</a></li>
        <li><a href='TotalPlanUsage.aspx'><i class='fas fa-chart-bar'></i> Input Account Total Plan Usage</a></li>
        <li><a href='AllSMSOffers.aspx'><i class='fas fa-sms'></i> Input Account SMS Offers</a></li>
        <li><a href='RemoveAllBenefits.aspx'><i class='fas fa-trash-alt'></i> Remove Input Account Benefits</a></li>
        <li><a href='AverageSentTransactionsAmounts.aspx'><i class='fas fa-chart-line'></i> Average Wallet Transactions</a></li>
        <li><a href='LinkedWallet.aspx'><i class='fas fa-link'></i> Input Mobile Number Wallet</a></li>
        <li><a href='WalletCashbackAmount.aspx'><i class='fas fa-hand-holding-usd'></i> Returned Cashback</a></li>
        <li><a href='UpdateTotalPoints.aspx'><i class='fas fa-edit'></i> Update Mobile Number Points</a></li>";
            }
            else if (role == "Customer")
            {
                navbarHtml += @"
        <li><a href='ViewAllBenefits.aspx'><i class='fas fa-gift'></i> All Active Benefits</a></li>
        <li><a href='ViewNonResolvedTickets.aspx'><i class='fas fa-ticket-alt'></i> Non-Resolved Tickets</a></li>
        <li><a href='HighestVoucherID.aspx'><i class='fas fa-certificate'></i> Highest Voucher</a></li>
        <li><a href='RemainingBalance.aspx'><i class='fas fa-balance-scale'></i> Remaining Balance</a></li>
        <li><a href='ExtraBalance.aspx'><i class='fas fa-money-bill-wave'></i> Extra Balance</a></li>
        <li><a href='Top10Payments.aspx'><i class='fas fa-list-ol'></i> Top 10 Payments</a></li>
        <li><a href='AllShops.aspx'><i class='fas fa-shopping-cart'></i> All Shops</a></li>
        <li><a href='CashbackCalculator.aspx'><i class='fas fa-calculator'></i> Cashback Calculator</a></li>
        <li><a href='LastFiveMonthSubscribedPlans.aspx'><i class='fas fa-history'></i> Recent Plans</a></li>
        <li><a href='RechargeBalance.aspx'><i class='fas fa-battery-full'></i> Recharge Balance</a></li>
        <li><a href='MyCashBack.aspx'><i class='fas fa-wallet'></i> Your Cashback</a></li>
        <li><a href='MyConsumption.aspx'><i class='fas fa-chart-pie'></i> Plan Consumption</a></li>
        <li><a href='MyUsage.aspx'><i class='fas fa-chart-area'></i> Plan Usage</a></li>
        <li><a href='UnsubscribedServices.aspx'><i class='fas fa-stream'></i> Other Plans</a></li>
        <li><a href='AllServicePlans.aspx'><i class='fas fa-th-list'></i> All Plans</a></li>
        <li><a href='RenewSubscription.aspx'><i class='fas fa-redo'></i> Renew Subscription</a></li>";
            }

            // Links for unauthenticated users
            navbarHtml += "<li><a href='AboutUs.aspx'><i class='fas fa-info-circle'></i> About Us</a></li>";

            // Add a login/logout link at the end
            if (role == null)
            {
                navbarHtml += "<li><a href='LoginCustomer.aspx'><i class='fas fa-sign-in-alt'></i> Log In as a Customer</a></li>";
                navbarHtml += "<li><a href='LoginAdmin.aspx'><i class='fas fa-user-lock'></i> Log In as an Admin</a></li>";
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