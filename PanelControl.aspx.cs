using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class PanelControl : System.Web.UI.Page
    {

        ListItem BrickInterfaceOption = new ListItem("Select Interface", "-1");
        ListItem UserInterfaceOption = new ListItem("User Interface", "1");
        ListItem AdminInterfaceOption = new ListItem("Admin Interface", "2");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InterfaceSelection.AutoPostBack = true;

                InterfaceSelection.Items.Add(BrickInterfaceOption);
                InterfaceSelection.Items.Add(UserInterfaceOption);
                InterfaceSelection.Items.Add(AdminInterfaceOption);

                UserInterfaceLabel.Text = "User Interface Being Shown.";
                AdminInterfaceLabel.Text = "Admin Interface Being Shown.";

                UserPanel.Visible = false;
                AdminPanel.Visible = false;
            }
        }

        protected void InterfaceSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(InterfaceSelection.SelectedValue == "1")
            {
                UserPanel.Visible = true;
                AdminPanel.Visible = false;
            }
            else if(InterfaceSelection.SelectedValue == "2")
            {
                UserPanel.Visible = false;
                AdminPanel.Visible = true;
            }
        }
    }
}