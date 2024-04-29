using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class ServerControlEvents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PostBackButton_Click(object sender, EventArgs e)
        {
            Response.Write("Post back event created when button clicked.");
            Response.Write("<br />");
        }

        protected void CachedEventTextbox_TextChanged(object sender, EventArgs e)
        {
            Response.Write("Cached event created when text changed. And is taken into account earlier than postback events.");
            Response.Write("<br />");

            // Response.Write("Post back event created when text changed due to AutoPostBack being true.");
            // Response.Write("<br />");
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Page pre-initialized.");
            Response.Write("<br />");
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Page initialized.");
            Response.Write("<br />");
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("Page initialization complete.");
            Response.Write("<br />");
        }

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("Page pre-loaded.");
            Response.Write("<br />");
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write("Page loaded completely.");
            Response.Write("<br />");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Page pre-rendered.");
            Response.Write("<br />");
        }

        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            Response.Write("Page pre-rendered completely.");
            Response.Write("<br />");
        }

        protected void Page_Unloaded(object sender, EventArgs e)
        {
            // Response.Write("Page unloaded.");
            // Response.Write("<br />");
            // Cannot be invoked since page will be destroyed from memory till now
        }

    }
}