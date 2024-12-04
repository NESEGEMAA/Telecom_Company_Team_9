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
    public partial class AllResolvedTickets : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Show_Tickets(object sender, EventArgs e)
        {
            GridView3.Visible = true;

        }
    }
}