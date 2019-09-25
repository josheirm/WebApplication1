using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace lobby
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["WaitingForSender"] = "not done";
            
            Application["WaitingForReciever"] = "not done";

            Application["ThisIsFirstPageLoad"] = "1";
           //waits for recive while to start for sender to send to
            Application["WaitingForCode"] = "no";
            //user 1 will be running send message first
            //first user  - so sets up recieving double while mechanism before sending
            Application["whoseturnisit"] = "1";
            

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            //user num 1 is 1, user num 0 is two
            Session["MyUserNumber"] = "0";
            Session["testit"] = "false";
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