using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class HyperlinkControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TheHyperLink.Text = "MyBlog";
            TheHyperLink.NavigateUrl = "https://thetahayaseen.pythonanywhere.com/logs";
            TheHyperLink.Target = "_blank";

            TheHyperLink.Focus();
        }
    }
}