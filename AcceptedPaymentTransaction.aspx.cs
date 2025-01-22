using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Reflection.Emit;

namespace Telecom_Company_Team_9
{
    public partial class AcceptedPaymentTransaction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Visible = false;
            PaymentsNumLabel.Visible = false;
            SumOfPointsLabel.Visible = false;

            if (Session["UserRole"] == null || Session["UserRole"].ToString() != "Admin")
            {
                // Redirect to login or access denied page if the user is not an admin
                Response.Redirect("~/LoginAdmin.aspx");
            }

            PaymentsNumLabel.Text = "Number of Payments: ";
            SumOfPointsLabel.Text = "Sum of points over payments: ";
        }
        protected void RetrievePaymentsButton_Click(object sender, EventArgs e)
        {
            PaymentsNumLabel.Visible = false;
            SumOfPointsLabel.Visible = false;
            Message.Visible = false;

            // Get the connection string
            string connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();
            string mobileNo = InputNumber.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(mobileNo) || mobileNo.Length != 11 || !long.TryParse(mobileNo, out _))
            {
                Message.Text = "Invalid mobile number. Please enter a valid 11-digit number.";
                Message.Visible = true;
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand cmd = new SqlCommand("Account_Payment_Points", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add input parameter
                        cmd.Parameters.Add(new SqlParameter("@MobileNo", mobileNo));

                        // Add output parameters
                        SqlParameter totalTransactionsParam = new SqlParameter("@TotalTransactions", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        SqlParameter totalPointsParam = new SqlParameter("@TotalPoints", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(totalTransactionsParam);
                        cmd.Parameters.Add(totalPointsParam);

                        // Open connection and execute
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        // Retrieve output values
                        int totalTransactions = totalTransactionsParam.Value != DBNull.Value ? (int)totalTransactionsParam.Value : 0;
                        int totalPoints = totalPointsParam.Value != DBNull.Value ? (int)totalPointsParam.Value : 0;

                        // Update labels
                        PaymentsNumLabel.Text = "Number of Payments: " + totalTransactions;
                        SumOfPointsLabel.Text = "Sum of points over payments: " + totalPoints;
                        PaymentsNumLabel.Visible = true;
                        SumOfPointsLabel.Visible = true;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                Message.Text = "A database error occurred: " + sqlEx.Message;
                Message.Visible = true;
            }
            catch (Exception ex)
            {
                Message.Text = "An unexpected error occurred: " + ex.Message;
                Message.Visible = true;
            }
        }
    }
}