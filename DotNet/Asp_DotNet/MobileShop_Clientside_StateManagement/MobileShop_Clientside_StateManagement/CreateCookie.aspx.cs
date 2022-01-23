using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MobileShop_Clientside_StateManagement
{
    public partial class CreateCookie : System.Web.UI.Page
    {
        HttpCookie mycookie;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "mobile";
            int count = 0;
            mycookie = new HttpCookie("mobile");
            foreach(ListItem m in CheckBoxList1.Items)
            {
                if(m.Selected==true)
                {
                    count++;
                    s = s + count;
                    mycookie.Values.Add(s, m.Text);
                }
            }
            this.Response.Cookies.Add(mycookie);
            Response.Redirect("ReadCookie.aspx");
        }
    }
}