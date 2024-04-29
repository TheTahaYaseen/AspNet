using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class ListBoxControl : System.Web.UI.Page
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

                Listbox.Items.Add(Diploma);
                Listbox.Items.Add(Graduate);
                Listbox.Items.Add(PostGraduate);
                Listbox.Items.Add(Doctorate);

                ConfirmButton.Text = "Confirm";

                // Listbox.SelectedValue = "4";
                Listbox.SelectedIndex = 3;
                Listbox.Rows = 2;
                Listbox.SelectionMode = ListSelectionMode.Multiple;
            }
        }

        protected void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (Listbox.SelectionMode == ListSelectionMode.Single)
            {
                if (Listbox.SelectedItem != null)
                {
                    Response.Write(String.Format("Text: {0}, Value: {1} & Index: {2}. <br/>", Listbox.SelectedItem.Text, Listbox.SelectedValue, Listbox.SelectedIndex));
                }
                else
                {
                    Response.Write(String.Format("Value: '{0}' & Index: '{1}'. <br/>", Listbox.SelectedValue, Listbox.SelectedIndex));
                }
            }
            else
            {
                foreach (ListItem CheckboxItem in Listbox.Items)
                {
                    if (CheckboxItem.Selected)
                    {
                        Response.Write(String.Format("Text: {0}, Value: {1} & Index: {2}. <br/>", CheckboxItem.Text, CheckboxItem.Value, Listbox.Items.IndexOf(CheckboxItem)));
                    }
                }
            }
        }
    }
}