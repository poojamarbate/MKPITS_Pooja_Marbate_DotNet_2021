using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CachingExample
{
    public partial class FullPageCache_Example : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.TimeOfDay.ToString();
              //  LAbel1.Text = DateTime.Now.TimeOfDay().ToString()l

        }
    }
}