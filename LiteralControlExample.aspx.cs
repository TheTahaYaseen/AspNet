using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class LiteralControlExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelControl.Text = Server.HtmlEncode("Label Control") ;
            LabelControl.ForeColor = Color.MidnightBlue;
            LabelControl.Font.Bold = true;

            // LiteralControl.Text = "<span style='color: MidnightBlue; font-weight: bold;'>Literal Control</span>";
            LiteralControl.Text = "Literal Control";
            LiteralControl.Mode = LiteralMode.Encode;
        }
    }
}