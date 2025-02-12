﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.AccessControl;
using System.Web.Configuration;
using System.Web.Services.Description;

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
                    lblTicketCount.Visible = true;
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
                lblTicketCount.Text = "Please insert a valid National ID";
                lblTicketCount.Visible = true;
                return;
            }

            // Fetch ticket count for the entered National ID
            DisplayTicketCount(nationalID);
        }

        // Method to display ticket count for a given National ID
        private void DisplayTicketCount(Int64 nationalID)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();

            string data = "EXEC Ticket_Account_Customer @NationalID, @unresolved OUTPUT";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand cmd = new SqlCommand(data, conn))
                    {
                        // Set the command type to Text (for raw SQL)
                        cmd.CommandType = CommandType.Text;

                        // Add input parameter
                        cmd.Parameters.AddWithValue("@NationalID", nationalID);

                        // Add output parameter
                        SqlParameter outputParam = new SqlParameter("@unresolved", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outputParam);

                        // Open the connection and execute
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        // Retrieve the output parameter value
                        int ticketcount = int.Parse(outputParam.Value.ToString());

                        if (ticketcount > 0)
                            lblTicketCount2.Text = "Number of Unresolved Tickets:  " + ticketcount;
                        else lblTicketCount2.Text = "No unresolved tickets found for the given National ID.";

                        lblTicketCount2.Visible = true;
                        lblTicketCount.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                lblTicketCount.Text = "No data found for the given National ID.";
                lblTicketCount.Visible = true;
            }
        }
    }
}
