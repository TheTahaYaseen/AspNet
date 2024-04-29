using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class RadioListControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListItem Diploma = new ListItem("Diploma", "1");
                ListItem Graduate = new ListItem("Graduate", "2");
                ListItem PostGraduate = new ListItem("PostGraduate", "3");
                ListItem Doctorate = new ListItem("Doctorate", "4");

                RadioList.RepeatDirection = RepeatDirection.Horizontal;

                RadioList.Items.Add(Diploma);
                RadioList.Items.Add(Graduate);
                RadioList.Items.Add(PostGraduate);
                RadioList.Items.Add(Doctorate);

                FetchButton.Text = "Fetch";
                ClearSelection.Text = "Clear Selection";
            }
        }

        protected void RadioList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void FetchButton_Click(object sender, EventArgs e)
        {
            if(RadioList.SelectedIndex != -1)
            {
                Response.Write(String.Format("Text: {0}, Value: {1} & Index: {2}. <br/>", RadioList.SelectedItem.Text, RadioList.SelectedValue, RadioList.SelectedIndex));
            }
        }

        protected void ClearSelection_Click(object sender, EventArgs e)
        {
            RadioList.SelectedIndex = -1;
        }
    }
}