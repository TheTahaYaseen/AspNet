using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class RadioCheckControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MaleRadioButton.TextAlign = TextAlign.Right;
                FemaleRadioButton.TextAlign = TextAlign.Right;

                MaleRadioButton.GroupName = "Genders";
                FemaleRadioButton.GroupName = "Genders";

                MaleRadioButton.Checked = true;
                FemaleRadioButton.AutoPostBack = true;
            }
        }

        protected void ChooseButton_Click(object sender, EventArgs e)
        {
            if (MaleRadioButton.Checked)
            {
                Response.Write("The gender is male.");
            }
            else
            {
                Response.Write("The gender is female.");
            }
        }

        protected void FemaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("Female radio button changed.");
        }
    }
}