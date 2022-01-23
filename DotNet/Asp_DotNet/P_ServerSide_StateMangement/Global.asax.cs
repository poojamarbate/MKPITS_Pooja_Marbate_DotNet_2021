using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace P_ServerSide_StateMangement
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["message"] = "CDR Vipin Rawal passed away in Air Crash";
            Application["Count"] = 0;

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            if (Application["Count"] != null)
            {
                Application.Lock();
                Application["Count"] = ((int)Application["Count"]) + 1;
                Application.UnLock();
            }

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}