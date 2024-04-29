using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class ListControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Populate(DropdownList);
            Populate(CheckboxList);
            Populate(Listbox);
            Populate(RadioList);
            Populate(BulletList);
        }

        private void GetSelections(ListControl List) 
        {
            foreach(ListItem Item in List.Items)
            {
                if (Item.Selected)
                {
                    Response.Write(String.Format("Text: {0}, Value: {1} & Index: {2}. <br/>", Item.Text, Item.Value, List.Items.IndexOf(Item)));
                }
            }
        }

        private void GetSelection(ListControl List)
        {
            if(List.SelectedIndex != -1)
            {
                Response.Write(String.Format("Text: {0}, Value: {1} & Index: {2}. <br/>", List.SelectedItem.Text, List.SelectedValue, List.SelectedIndex));
            }
        }

        private void Populate(ListControl List)
        {
            ListItem Flour = new ListItem("Flour", "Flour");
            ListItem Cocoa = new ListItem("Cocoa", "Cocoa");
            ListItem Milk = new ListItem("Milk", "Milk");

            List.Items.Add(Flour);
            List.Items.Add(Cocoa);
            List.Items.Add(Milk);
        }

        protected void ConfirmButton_Click(object sender, EventArgs e)
        {
            GetSelection(DropdownList);
            GetSelection(RadioList);

            GetSelections(Listbox);
            GetSelections(CheckboxList);
        }
    }
}