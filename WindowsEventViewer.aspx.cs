using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class WindowsEventViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ProceedButton_Click(object sender, EventArgs e)
        {
            if(EventLogNameInput.Text != string.Empty && EventLogSourceInput.Text != string.Empty)
            {
                System.Diagnostics.EventLog.CreateEventSource(EventLogSourceInput.Text, EventLogNameInput.Text);
                Response.Write(String.Format("{0} Log with Name {1} created.", EventLogSourceInput.Text, EventLogNameInput.Text));
            }
            else
            {
                Response.Write(String.Format("{0} Log with Name {1} not created.", EventLogSourceInput.Text, EventLogNameInput.Text));
            }
        }
    }
}