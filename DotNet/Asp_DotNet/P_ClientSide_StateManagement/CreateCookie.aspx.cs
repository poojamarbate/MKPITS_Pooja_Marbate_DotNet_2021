using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P_ClientSide_StateManagement
{
    public partial class CreateCookie : System.Web.UI.Page
    {
        HttpCookie mycookee;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "prn";
            int count = 0;
            mycookee = new HttpCookie("print cookee");
            foreach(ListItem p in CheckBoxList1.Items)
            {
                if(p.Selected==true)
                {
                    count++;
                    s = s + count;
                    mycookee.Values.Add(s, p.Text);
                }
            }

            this.Response.Cookies.Add(mycookee);
            mycookee.Expires.AddDays(29);
            Response.Redirect("ReadCookie.aspx");
        }
    }
}