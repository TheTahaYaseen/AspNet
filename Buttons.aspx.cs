using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class Buttons : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button.Text = "I Am Ironman";
            LinkButton.Text = "Blogs";
            ImageButton.ImageUrl = "https://thetahayaseen.pythonanywhere.com/static/media/images/Portfolio.png";
            ImageButton.OnClientClick = "alert('Code 10: Submission taking place, ok?')";
            LinkButton.OnClientClick = "confirm('Code 10: are you sure to submit?')";
        }

        protected void LinkButton_Click(object sender, EventArgs e)
        {
            Response.Write("link Button clicked!");
        }

        protected void ImageButton_Click(object sender, ImageClickEventArgs e)
        {
            Response.Write("Button clicked!");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}