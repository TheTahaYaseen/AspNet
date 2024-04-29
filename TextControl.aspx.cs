using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class TextControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox.TextMode = TextBoxMode.SingleLine;
                MultilineBox.TextMode = TextBoxMode.MultiLine;
                PasswordBox.TextMode = TextBoxMode.Password;

                TextBox.AutoPostBack = true;
                MultilineBox.Focus();

                MultilineBox.Columns = 32;
                MultilineBox.Rows = 3;
                MultilineBox.Height = 90;
                MultilineBox.Width = 200;

                MultilineBox.Text = "C# is one of the most powerful languages and is the language of a real dev.";
                MultilineBox.ReadOnly = true;

                PasswordBox.MaxLength = 8;

                MultilineBox.ToolTip = "Said by a wise man, one known as Sir Murtuza.";
            }
        }

        protected void TextBox_TextChanged(object sender, EventArgs e)
        {
            Response.Write(String.Format("Text changed to {0}", TextBox.Text));
        }
    }
}