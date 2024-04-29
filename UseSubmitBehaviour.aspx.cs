using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class UseSubmitBehaviour : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClearButton.Text = "Clear";
                SubmitButton.Text = "Submit";

                WrittenLabel.ForeColor = Color.RoyalBlue;
                WrittenLabel.Font.Bold = true;
                WrittenLabel.Text = "";

                ClearButton.UseSubmitBehavior = false;
            }
        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {
            WrittenInput.Text = string.Empty;
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            WrittenLabel.Text = "You entered: " + WrittenInput.Text;
        }
    }
}