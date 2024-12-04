using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecom_Company_Team_9
{
    public partial class ActiveAccounts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Show_Accounts(object sender, EventArgs e)
        {
            GridView1.Visible = true;
        }
    }
}