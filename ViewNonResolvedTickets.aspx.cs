using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecom_Company_Team_9
{
    public partial class ViewNonResolvedTickets : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
        //Part 2 Component 2
        protected void ViewTickets(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
            String nationalID = NID.Text;

            SqlCommand count_func = new SqlCommand("Ticket_Account_Customer", conn);
            count_func.CommandType = CommandType.StoredProcedure;

            count_func.Parameters.Add(new SqlParameter("@NID", nationalID));

            conn.Open();

            if (!AreDigitsOnly(nationalID))
            {
                lblTicketCount.Text = "Please insert a valid National ID";
                return;
            }

            if (!int.TryParse(nationalID, out _))
            {
                lblTicketCount.Text = "Error: National ID must be a valid integer and within the range of 0 to 2,147,483,647.";
                return;
            }
            object reader = count_func.ExecuteScalar();


            if (reader != null && int.TryParse(reader.ToString(), out int ticketcount))
            {
                if (ticketcount > 0)
                {
                    lblTicketCount.Text = "Number of Unresolved Tickets:  " + ticketcount;
                }

                else
                {
                    lblTicketCount.Text = "No data found for the given National ID.";
                }





            }

            else
            {
                lblTicketCount.Text = "No data found for the given National ID.";
            }



            conn.Close();

        }
    }
}