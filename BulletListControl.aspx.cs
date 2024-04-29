using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class BulletListControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListItem Taha = new ListItem("Taha", "https://thetahayaseen.pythonanywhere.com/");
                ListItem Rafay = new ListItem("Rafay", "https://rafayyaseen.pythonanywhere.com/");

                BulletList.Items.Add(Taha);
                BulletList.Items.Add(Rafay);

                // BulletList.BulletStyle = BulletStyle.CustomImage;
                // BulletList.BulletImageUrl = "https://thetahayaseen.pythonanywhere.com/static/media/images/Portfolio.png";

                BulletList.BulletStyle = BulletStyle.Disc;

                // BulletList.DisplayMode = BulletedListDisplayMode.HyperLink;
                // BulletList.Target = "_blank";

                BulletList.DisplayMode = BulletedListDisplayMode.LinkButton;
            }
        }

        protected void BulletList_Click(object sender, BulletedListEventArgs e)
        {
            ListItem ItemClicked = BulletList.Items[e.Index];

            Response.Write(String.Format("Text: {0}, Value: {1} & Index: {2}. <br/>", ItemClicked.Text, ItemClicked.Value, e.Index));

        }
    }
}