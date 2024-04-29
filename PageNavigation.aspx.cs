using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class PageNavigation : System.Web.UI.Page
    {

        public string Opinion
        {
            get
            {
                return OpinionInput.Text;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Hyperlink.NavigateUrl = "~/AdRotator.aspx";
            Hyperlink.Text = "Hyperlink - The Ads";
            ResponseRedirectButton.Text = "Redirect To Ads";

            ServerTransferButton.Text = "Server Transfer - Redirect To Opinion Show";
            ServerExternalTransferButton.Text = "Redirect To External Site (Will Throw A RunTime Error)";

            ServerExecuteButton.Text = "Server Execute - Opinion Show";
            ServerExternalExecuteButton.Text = "Redirect To External Site (Will Throw A RunTime Error)";

            CrossPagePostButton.Text = "Send Cross Page Post Request";
            CrossPagePostButton.PostBackUrl = "~/OpinionShow.aspx";

            OpenNewWindowUsingCodeButton.Text = "OpenNewWindowUsingC#CodeButton";
            QueryStringInformationRetrieval.Text = "QueryStringInformationRetrieval";

            CookieCreateButton.Text = "Send Data Through Cookie";
            SessionCreateButton.Text = "Send Data Through Session";
            ApplicationCreateButton.Text = "Send Data Through App Vars";
        }

        protected void ResponseRedirectButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdRotator.aspx");
            Response.Redirect("https://thetahayaseen.pythonanywhere.com/");
        }

        protected void ServerTransferButton_Click(object sender, EventArgs e)
        {
            // Server.Transfer("~/OpinionShow.aspx", false);
            Server.Transfer("~/OpinionShow.aspx");
        }

        protected void ServerExternalTransferButton_Click(object sender, EventArgs e)
        {
            Server.Transfer("https://thetahayaseen.pythonanywhere.com/");
        }

        protected void ServerExecuteButton_Click(object sender, EventArgs e)
        {
            Server.Execute("~/OpinionShow.aspx");
        }

        protected void ServerExternalExecuteButton_Click(object sender, EventArgs e)
        {
            Server.Execute("https://thetahayaseen.pythonanywhere.com/");
        }

        protected void OpenNewWindowUsingCodeButton_Click(object sender, EventArgs e)
        {
            string JSCode = "<script>window.open('OpinionShow.aspx?Opinion=" + OpinionInput.Text + "', '_self', 'location=no,resizable=no', false);</script>";
            Response.Write(JSCode);
        }

        protected void QueryStringInformationRetrieval_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/OpinionShow.aspx?Opinion=" + Server.UrlEncode(Opinion) + "&ComplimentaryRemark=IAmIronman" );
        }

        protected void CookieCreateButton_Click(object sender, EventArgs e)
        {
            HttpCookie OpinionCookie = new HttpCookie("Opinion");
            OpinionCookie["GenuineOpinion"] = "I am ironman";
            OpinionCookie["EnteredOpinion"] = Opinion;
            OpinionCookie.Expires = DateTime.Now.AddHours(12);
            Response.Cookies.Add(OpinionCookie);
            Response.Redirect("~/OpinionShow.aspx");
        }

        protected void SessionCreateButton_Click(object sender, EventArgs e)
        {
            Session["Opinion"] = OpinionInput.Text;
            Response.Redirect("~/OpinionShow.aspx");
        }

        protected void ApplicationCreateButton_Click(object sender, EventArgs e)
        {
            Application["Opinion"] = OpinionInput.Text;
            Response.Redirect("~/OpinionShow.aspx");
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                int OpinionInt = Convert.ToInt32(OpinionInput.Text);
                Response.Write("Integer Added In Opinion = " + OpinionInt);
            }
            catch(FormatException FormatError)
            {
                Logger.Log(FormatError, System.Diagnostics.EventLogEntryType.Information);
                Response.Write("Please enter an integer with a valid format.");
                if (Trace.IsEnabled)
                {
                    Trace.Write("Please enter an integer with a valid format");
                }
            }
            catch (Exception Error)
            {
                Logger.Log(Error);
                Response.Write("Please enter a valid integer. An unknown exception occured.");
                if (Trace.IsEnabled)
                {
                    Trace.Warn("Please enter a valid integer. An unknown exception occured.");
                }
            }
        }
    }
}