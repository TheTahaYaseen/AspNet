using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class CheckCookiesStatus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Browser.Cookies)
                {
                    if (Request.QueryString["CookieCheck"] == null)
                    {
                        HttpCookie CookieCheck = new HttpCookie("CookieCheck", "Check");
                        Response.Cookies.Add(CookieCheck);
                        Response.Redirect("~/CheckCookiesStatus.aspx?CookieCheck=True");
                    }
                    else
                    {
                        HttpCookie CookieCheck = Response.Cookies["CookieCheck"];
                        RelativeCookieRelatedInfo.Text = CookieCheck == null ? "Cookies are disabled." : "Cookies are enabled.";
                    }
                }
                else
                {
                    RelativeCookieRelatedInfo.Text = "Cookies are not supported by the browser.";
                }
            }
        }

    }
}