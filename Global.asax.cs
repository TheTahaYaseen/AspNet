using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Asp.Net
{
    public class Global : HttpApplication
    {

        void Application_Error(object sender, EventArgs e)
        {
            Exception Error = Server.GetLastError();
            if(Error != null)
            {
                Logger.Log(Error);
                Server.ClearError();
                Server.Transfer("~/OpinionShow.aspx?Opinion=An error occured&ComplimentaryRemark=Will be fixed soon.");
            }
        }

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Application["ApplicationsRunning"] = 0;
            Application["SessionsRunning"] = 0;

            Application["ApplicationsRunning"] = (int)Application["ApplicationsRunning"] + 1;
        }

        void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();
            Application["SessionsRunning"] = (int)Application["SessionsRunning"] + 1;
            Application.UnLock();
        }

        void Session_End(object sender, EventArgs e)
        {
            Application["SessionsRunning"] = (int)Application["SessionsRunning"] - 1;
        }

    }
}