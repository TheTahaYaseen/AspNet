using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class OpinionShow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // System.Collections.Specialized.NameValueCollection PreviousFormNameValues = Request.Form;
            // string Opinion = PreviousFormNameValues["OpinionInput"];
            // OpinionLabel.Text = Opinion;

            // PageNavigation PreviousPage = (PageNavigation)Page.PreviousPage;
            // PageNavigation PreviousPage = this.PreviousPage;

            // if (PreviousPage != null)
            // {
            //     if (PreviousPage.IsCrossPagePostBack)
            //     {
            //         Opinion = "You entered through a cross page post back, so the opinion is " + PreviousPage.Opinion;
            //     }
            //     else
            //     {
            //         Opinion = "You entered through a technique other than cross page post back, so the opinion is " + PreviousPage.Opinion;
            //     }
            // }
            // else
            // {
            //     if (Request.QueryString["Opinion"] != null)
            //     {
            //         Opinion = "You directly came to this page, so opinion is " + Request.QueryString["Opinion"];
            //     }
            //     else
            //     {
            //         Opinion = "You directly came to this page, so opinion is empty.";
            //     }
            // }

            // OpinionLabel.Text = Opinion;

            Page LastPage = (Page)Context.Handler;
            if(LastPage is PageNavigation)
            {
                OpinionLabel.Text = ((PageNavigation)LastPage).Opinion;
            }

            if (Request.QueryString["ComplimentaryRemark"] != null)
            {
                OpinionLabel.Text = Request.QueryString[0] + " " + Request.QueryString[1];
            }

            if(Request.Cookies["Opinion"] != null)
            {
                HttpCookie OpinionCookie = Request.Cookies["Opinion"];
                OpinionLabel.Text = OpinionCookie["GenuineOpinion"] + " " + OpinionCookie["EnteredOpinion"];
            }
            
            if(Session["Opinion"] != null)
            {
                OpinionLabel.Text = Session["Opinion"].ToString();
            }

            if(Application["Opinion"] != null)
            {
                OpinionLabel.Text = Application["Opinion"].ToString();
            }
        }
    }
}