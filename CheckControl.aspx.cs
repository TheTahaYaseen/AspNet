using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class CheckControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack)
            {

                TellButton.Text = "Tell";
                WebDevCheck.Text = "WebDevCheck";
                WebAppCheck.Text = "WebAppCheck";

                WebDevCheck.TextAlign = TextAlign.Left;
                WebAppCheck.TextAlign = TextAlign.Right;

                WebDevCheck.Focus();

                WebAppCheck.AutoPostBack = true;
            }
        }

        protected void TellButton_Click(object sender, EventArgs e)
        {
            if (WebDevCheck.Checked && WebAppCheck.Checked)
            {
                Response.Write("You're a full stack dev.");
            }
        }

        protected void WebAppCheck_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("You're a web app dev.");
        }
    }
}