using System;
using System.Collections.Generic;

namespace Asp.Net
{
    public partial class HiddenField : System.Web.UI.Page
    {
        private Dictionary<string, string> EmployeeInfo = new Dictionary<string, string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                EmployeeInfo.Add("Id", "1"); 
                EmployeeInfo.Add("Name", "The Taha Yaseen");
                EmployeeInfo.Add("Quote", "Embrace your destiny so as not to accept but to change it.");
            }
        }

        protected void LoadButton_Click(object sender, EventArgs e)
        {
            HiddenEmployeeId.Value = EmployeeInfo["Id"];
            NameInput.Text = EmployeeInfo["Name"];
            QuoteInput.Text = EmployeeInfo["Quote"];
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            EmployeeInfo["Name"] = NameInput.Text;
            EmployeeInfo["Quote"] = QuoteInput.Text;
        }
    }
}
