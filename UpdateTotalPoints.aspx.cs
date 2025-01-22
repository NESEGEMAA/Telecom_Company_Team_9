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
    public partial class UpdateTotalPoints : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Visible=false;
            Message2.Visible = false;
            if (Session["UserRole"] == null || Session["UserRole"].ToString() != "Admin")
            {
                // Redirect to login or access denied page if the user is not an admin
                Response.Redirect("~/LoginAdmin.aspx");
            }
        }

        protected void UpdateTotalPointsButton_Click(object sender, EventArgs e)
        {
            // Get the connection string from Web.config
            string connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();
            string mobileNo = InputNumber.Text.Trim();

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand cmd = new SqlCommand("Total_Points_Account", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add input parameter
                        cmd.Parameters.Add(new SqlParameter("@MobileNo", SqlDbType.VarChar, 15)
                        {
                            Value = mobileNo
                        });

                        // Add output parameter
                        SqlParameter newPointsParam = new SqlParameter("@newPoints", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(newPointsParam);

                        // Open the connection
                        conn.Open();

                        // Execute the stored procedure
                        cmd.ExecuteNonQuery();

                        // Retrieve the output parameter value with DBNull check
                        int newPoints = newPointsParam.Value != DBNull.Value ? (int) newPointsParam.Value : 0;

                        if (newPoints > 0)
                        {
                            Message2.Text = $"Wallet points updated successfully. New Points: {newPoints}";
                            Message2.Visible = true;
                        }
                        else
                        {
                            Message.Text = "No points found or Mobile Number not found.";
                            Message.Visible = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Message.Text = "An error occurred: " + ex.Message;
                Message.Visible = true;
            }
        }
    }
}