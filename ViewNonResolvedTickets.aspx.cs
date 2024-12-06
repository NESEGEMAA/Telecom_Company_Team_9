using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Telecom_Company_Team_9
{
    public partial class ViewNonResolvedTickets : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblTicketCount.Visible = false;
            lblTicketCount2.Visible = false;
            if (Session["UserRole"] == null || Session["UserRole"].ToString() != "Customer")
            {
                // Redirect to login or access denied page if the user is not a customer
                Response.Redirect("~/LoginCustomer.aspx");
            }

            // Show ticket count for the default National ID on page load
            if (!IsPostBack)
            {
                try
                {
                    Int64 DefaultNationalID = int.Parse(Session["NID"] as string); // Default mobile number
                    DisplayTicketCount(DefaultNationalID);
                }
                catch
                {
                    lblTicketCount.Text = "Customer NID in database is invalid for some reason :(";
                }
            }
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

        // Part 2 Component 2
        protected void ViewTickets(object sender, EventArgs e)
        {
            Int64 nationalID = 0;
            try
            {
                nationalID = int.Parse(NID.Text);
            }
            catch
            {
                lblTicketCount2.Text = "Please insert a valid National ID";
                return;
            }

            // Fetch ticket count for the entered National ID
            DisplayTicketCount(nationalID);
        }

        // Method to display ticket count for a given National ID
        private void DisplayTicketCount(Int64 nationalID)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand count_func = new SqlCommand("Ticket_Account_Customer", conn);
            count_func.CommandType = CommandType.StoredProcedure;
            count_func.Parameters.Add(new SqlParameter("@NID", nationalID));

            conn.Open();

            object reader = count_func.ExecuteScalar();

            if (reader != null && int.TryParse(reader.ToString(), out int ticketcount))
            {
                if (ticketcount > 0)
                {
                    lblTicketCount.Text = "Number of Unresolved Tickets:  " + ticketcount;
                }
                else
                {
                    lblTicketCount.Text = "No unresolved tickets found for the given National ID.";
                }
            }
            else
            {
                lblTicketCount2.Text = "No data found for the given National ID.";
            }

            conn.Close();
        }
    }
}
