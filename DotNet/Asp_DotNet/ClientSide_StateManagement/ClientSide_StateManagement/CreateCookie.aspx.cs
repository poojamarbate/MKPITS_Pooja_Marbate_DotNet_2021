using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientSide_StateManagement
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
            mycookee = new HttpCookie("printercookie");//employee e1=new employee()
            foreach(ListItem p in CheckBoxList1.Items)
            {
                if (p.Selected == true)
                {
                    count++;
                    s = s + count;//prn1
                    mycookee.Values.Add(s, p.Text);
                    //key prn1,p.text="HP"
                    //key prn2,p.text="asus"

                }
            }
            //temporary cookie 
            //persistant cookie
            this.Response.Cookies.Add(mycookee);
            mycookee.Expires.AddDays(29);
            Response.Redirect("ReadCookie.aspx");
        }
    }
}