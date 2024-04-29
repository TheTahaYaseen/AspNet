using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class AnonymousAuth : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Apllication code is executed on " + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "<br/>");

            Response.Write("Is user authenticated " + User.Identity.IsAuthenticated.ToString() + "<br/>");

            Response.Write("Authentication type, if authenticated " + User.Identity.AuthenticationType + "<br/>");
            
            Response.Write("Username if authenticated " + User.Identity.Name + "<br/>");
        }
    }
}