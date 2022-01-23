using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P_ClientSide_StateManagement
{
    public partial class ReadCookie : System.Web.UI.Page
    {
        HttpCookie r;
        protected void Page_Load(object sender, EventArgs e)
        {
            r = Request.Cookies["print cookee"];
            for(int i=0;i<r.Values.Count;i++)
            {
                BulletedList1.Items.Add(r.Values[i]);
            }
            BulletedList1.DataBind();
        }
    }
}