using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Get_PostExample
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string s1, s2;
        protected void Page_Load(object sender, EventArgs e)
        {
            s1 = Request.Form.Get("studname").ToString();
            s2 = Request.Form.Get("City").ToString();
            Label1.Text = s1;
            Label2.Text = s2;
        }
    }
}