using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MobileShop_Clientside_StateManagement
{
    public partial class ReadCookie : System.Web.UI.Page
    {
        HttpCookie h;
        protected void Page_Load(object sender, EventArgs e)
        {
            h = Request.Cookies["mobile"];
            for(int i=0;i<h.Values.Count;i++)
            {
                BulletedList1.Items.Add(h.Values[i]);
            }
            BulletedList1.DataBind();

        }
    }
}