using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class CheckBoxesList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListItem Diploma = new ListItem("Diploma", "1");
                Diploma.Enabled = false;

                ListItem Graduate = new ListItem("Graduate", "2");
                ListItem PostGraduate = new ListItem("PostGraduate", "3");
                ListItem Doctorate = new ListItem("Doctorate", "4");

                CheckboxList.RepeatDirection = RepeatDirection.Horizontal;
                CheckboxList.RepeatColumns = 2;

                CheckboxList.Items.Add(Diploma);
                CheckboxList.Items.Add(Graduate);
                CheckboxList.Items.Add(PostGraduate);
                CheckboxList.Items.Add(Doctorate);

                ConfirmButton.Text = "Confirm";

                // CheckboxList.SelectedValue = "4";
                CheckboxList.SelectedIndex = 3;

                SelectAllButton.Text = "Select All";
                DeselectAllButton.Text = "Deselect All";
            }
        }

        protected void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (CheckboxList.SelectedItem != null)
            {
                Response.Write(String.Format("Text: {0}, Value: {1} & Index: {2}. <br/>", CheckboxList.SelectedItem.Text, CheckboxList.SelectedValue, CheckboxList.SelectedIndex));
            }
            else
            {
                Response.Write(String.Format("Value: '{0}' & Index: '{1}'. <br/>", CheckboxList.SelectedValue, CheckboxList.SelectedIndex));
            }

            foreach (ListItem CheckboxItem in CheckboxList.Items)
            {
                if (CheckboxItem.Selected)
                {
                    Response.Write(String.Format("Text: {0}, Value: {1} & Index: {2}. <br/>", CheckboxItem.Text, CheckboxItem.Value, CheckboxList.Items.IndexOf(CheckboxItem)));
                }
            }
        }

        protected void SelectAllButton_Click(object sender, EventArgs e)
        {
            foreach (ListItem CheckboxItem in CheckboxList.Items)
            {
                CheckboxItem.Selected = true;
            }
        }

        protected void DeselectAllButton_Click(object sender, EventArgs e)
        {
            foreach (ListItem CheckboxItem in CheckboxList.Items)
            {
                CheckboxItem.Selected = false;
            }
        }
    }
}