using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class ListCheck_Box_Example : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListItem Diploma = new ListItem("Diploma", "1");
                ListItem Graduate = new ListItem("Graduate", "2");
                ListItem PostGraduate = new ListItem("PostGraduate", "3");
                ListItem Doctorate = new ListItem("Doctorate", "4");

                CheckboxList.RepeatDirection = RepeatDirection.Horizontal;

                CheckboxList.Items.Add(Diploma);
                CheckboxList.Items.Add(Graduate);
                CheckboxList.Items.Add(PostGraduate);
                CheckboxList.Items.Add(Doctorate);

                CheckboxList.AutoPostBack = true;

                Label.ForeColor = Color.Red;
                Label.Text = "0 item(s) selected";
            }
        }

        protected void CheckboxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CheckboxList.SelectedIndex == -1)
            {
                Label.ForeColor = Color.Red;
                Label.Text = "0 item(s) selected";
            }
            else
            {
                Label.ForeColor = Color.Black;
                Listbox.Items.Clear();

                foreach(ListItem Item in CheckboxList.Items)
                {
                    if (Item.Selected)
                    {
                        Listbox.Items.Add(Item.Text);
                    }
                    Label.Text = Listbox.Items.Count.ToString() + " item(s) selected";
                }
            }
        }
    }
}