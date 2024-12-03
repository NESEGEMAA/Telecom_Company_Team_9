using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecom_Company_Team_9
{
    public partial class admin_view : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            Response.Write(Session["admin"]);
        }
        protected void Show_Accounts(object sender, EventArgs e)
        {
            GridView1.Visible = true;
            GridView2.Visible = false;
            GridView3.Visible = false;
            GridView4.Visible = false;
            GridView5.Visible = false;
            Button6.Visible = false;
            Calendar1.Visible = false;
            TextBox1.Visible = false;
            Button7.Visible = false;
            TextBox2.Visible = false;
            TextBox3.Visible = false;
            TextBox5.Visible = false;
            Calendar2.Visible = false;
            Button10.Visible = false;
            TextBox4.Visible = false;
            Button9.Visible = false;
            GridView7.Visible = false;
            GridView6.Visible = false;
            Label1.Visible = false;
        }
        protected void Show_Stores(object sender, EventArgs e)
        {
            GridView2.Visible = true;
            GridView1.Visible = false;
            GridView3.Visible = false;
            GridView4.Visible = false;
            GridView5.Visible = false;
            Button6.Visible = false;
            Calendar1.Visible = false;
            TextBox1.Visible = false;
            Button7.Visible = false;
            TextBox2.Visible = false;
            TextBox3.Visible = false;
            TextBox5.Visible = false;
            Calendar2.Visible = false;
            Button10.Visible = false;
            TextBox4.Visible = false;
            Button9.Visible = false;
            GridView6.Visible = false;
            GridView7.Visible = false;
            Label1.Visible = false;
        }


        protected void Show_Tickets(object sender, EventArgs e)
        {
            GridView3.Visible = true;
            GridView2.Visible = false;
            GridView1.Visible = false;
            GridView4.Visible = false;
            GridView5.Visible = false;
            Button6.Visible = false;
            Calendar1.Visible = false;
            TextBox1.Visible = false;
            Button7.Visible = false;
            TextBox2.Visible = false;
            TextBox3.Visible = false; 
            TextBox5.Visible = false;
            Calendar2.Visible = false;
            Button10.Visible = false;
            TextBox4.Visible = false;
            Button9.Visible = false;
            GridView7.Visible = false;
            GridView6.Visible = false;
            Label1.Visible = false;

        }

        protected void Show_Plans(object sender, EventArgs e)
        {
            GridView4.Visible = true;
            GridView3.Visible = false;
            GridView2.Visible = false;
            GridView1.Visible = false;
            GridView5.Visible = false;
            Button6.Visible = false;
            Calendar1.Visible = false;
            TextBox1.Visible = false;
            Button7.Visible = false;
            TextBox2.Visible = false;
            TextBox3.Visible = false;
            TextBox5.Visible = false;
            Calendar2.Visible = false;
            Button10.Visible = false;
            TextBox4.Visible = false;
            Button9.Visible = false;
            GridView7.Visible = false;
            GridView6.Visible = false;
            Label1.Visible = false;

        }

        protected void OnMyDataSourceSelecting1(object sender, SqlDataSourceSelectingEventArgs e)
        {
            Int32 planID = int.Parse(TextBox1.Text);
            DateTime dateTime = Calendar1.SelectedDate;
            e.Command.Parameters["@date"].Value = dateTime;
            e.Command.Parameters["@plan"].Value = planID;
            Response.Write("ha5a");

        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            GridView4.Visible = false;
            GridView3.Visible = false;
            GridView2.Visible = false;
            GridView1.Visible = false;
            Button6.Visible = true;
            Calendar1.Visible = true;
            TextBox1.Visible = true;
            Button7.Visible = false;
            TextBox2.Visible = false;
            TextBox3.Visible = false;
            TextBox5.Visible = false;
            Calendar2.Visible = false;
            Button10.Visible = false;
            TextBox4.Visible = false;
            Button9.Visible = false;
            GridView7.Visible = false;
            GridView6.Visible = false;
            Label1.Visible = false;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            SqlDataSource5.SelectCommand = "SELECT Account_Plan_date_1.* FROM dbo.Account_Plan_date(@date,@plan) AS Account_Plan_date_1" + Request.QueryString["@date"] + Request.QueryString["@plan"];
            SqlDataSource5.DataBind();
            GridView5.Visible=true;
        }
        protected void ExecuteStoredProcedure(int mobile, int PlanID)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("Benefits_Account", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@mobile_num", mobile);
                        cmd.Parameters.AddWithValue("@plan_id", PlanID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"ID: {reader["Id"]}, Name: {reader["Name"]}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {

            int mobile = int.Parse(TextBox2.Text);
            int planID = int.Parse(TextBox3.Text);
            ExecuteStoredProcedure(mobile, planID);
            Response.Write("Benefits Deleted Sucessfully!");

        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Button7.Visible = true;
            TextBox2.Visible = true;
            TextBox3.Visible = true;
            GridView4.Visible = false;
            GridView3.Visible = false;
            GridView2.Visible = false;
            GridView1.Visible = false;
            Button6.Visible = false;
            Calendar1.Visible = false;
            TextBox1.Visible = false;
            TextBox5.Visible = false;
            Calendar2.Visible = false;
            Button10.Visible = false;
            TextBox4.Visible = false;
            Button9.Visible = false;
            GridView7.Visible = false;
            GridView6.Visible = false;
            Label1.Visible = false;
        }

        protected void OnMyDataSourceSelecting2(object sender, SqlDataSourceSelectingEventArgs e)
        {
            String mobile = TextBox4.Text;
            mobile.PadRight(11);
            e.Command.Parameters["@mobile_no"].Value = mobile;
            Response.Write("ha5a");
        }

        protected void OnMyDataSourceSelecting3(object sender, SqlDataSourceSelectingEventArgs e)
        {
            String mobile = TextBox5.Text;
            mobile.PadRight(11);
            DateTime date = Calendar2.SelectedDate;
            e.Command.Parameters["@mobile_no"].Value = mobile;
            e.Command.Parameters["@from_date"].Value = date;
            Response.Write("ha5a");


        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            ShowAccountSMSOffers(sender, e);
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            ShowTotalUsage(sender, e);
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Button7.Visible = false;
            TextBox2.Visible = false;
            TextBox3.Visible = false;
            GridView4.Visible = false;
            GridView3.Visible = false;
            GridView2.Visible = false;
            GridView1.Visible = false;
            Button6.Visible = false;
            Calendar1.Visible = false;
            TextBox1.Visible = false;
            TextBox5.Visible = true;
            Calendar2.Visible = true;
            Button10.Visible = true;
            TextBox4.Visible = false;
            Button9.Visible = false;
            GridView7.Visible = false;
            GridView6.Visible = false;

        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            Button7.Visible = false;
            TextBox2.Visible = false;
            TextBox3.Visible = false;
            GridView4.Visible = false;
            GridView3.Visible = false;
            GridView2.Visible = false;
            GridView1.Visible = false;
            Button6.Visible = false;
            Calendar1.Visible = false;
            TextBox1.Visible = false;
            TextBox5.Visible = false;
            Calendar2.Visible = false;
            Button10.Visible = false;
            TextBox4.Visible = true;
            Button9.Visible = true;
            GridView7.Visible = false;
            GridView6.Visible = false;
            Label1.Visible = false;

        }
        protected void ShowAccountSMSOffers(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();

            String data = "SELECT Account_SMS_Offers_1.* FROM dbo.Account_SMS_Offers(@mobile) AS Account_SMS_Offers_1";

            string mobileNumber = TextBox4.Text;

            // Define the mobile number pattern
            string pattern = @"^\+?[0-9]{10,15}$";

            // Validate the mobile number using Regex
            if (Regex.IsMatch(mobileNumber, pattern))
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand cmd = new SqlCommand(data, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@mobile", mobileNumber);

                        // Open the connection and execute the query
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        SqlDataAdapter reader = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        reader.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            GridView6.DataSource = dt;
                            GridView6.DataBind();
                            GridView6.Visible = true;
                            Label1.Visible = false;
                        }
                        else
                        {
                            Label1.Text = "No plans available to display.";
                            Label1.Visible = true;
                            GridView6.Visible = false;
                        }

                        conn.Close();
                    }
                }
            }
            else
            {
                Label1.Text = "Invalid mobile number format";
                Label1.Visible = true;
                GridView6.Visible = false;

            }
        }
        protected void ShowTotalUsage(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();

            String data = "SELECT Account_Usage_Plan_1.* FROM dbo.Account_Usage_Plan(@mobile_no,@from_date) AS Account_Usage_Plan_1";

            string mobileNumber = TextBox5.Text;
            DateTime date = Calendar2.SelectedDate;

            // Define the mobile number pattern
            string pattern = @"^\+?[0-9]{10,15}$";

            // Validate the mobile number using Regex
            if (Regex.IsMatch(mobileNumber, pattern) && date <= DateTime.Today)
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand cmd = new SqlCommand(data, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@mobile_no", mobileNumber);
                        cmd.Parameters.AddWithValue("@from_date", date);

                        // Open the connection and execute the query
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        SqlDataAdapter reader = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        reader.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            GridView7.DataSource = dt;
                            GridView7.DataBind();
                            GridView7.Visible = true;
                            Label2.Visible = false;
                        }
                        else
                        {
                            Label2.Text = "No plans available to display.";
                            Label2.Visible = true;
                            GridView6.Visible = false;
                        }

                        conn.Close();
                    }
                }
            }
            else
            {
                Label2.Text = "Invalid Input Format";
                Label2.Visible = true;
                GridView7.Visible = false;

            }
        }
    }
}