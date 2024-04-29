using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class WizardControlTemplates : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // MainWizard$StepNavigationTemplateContainerID$StepPreviousButton
                Button StepNavigationNextButton = (Button)MainWizard.FindControl("StepNavigationTemplateContainerID").FindControl("StepNextButton");
                StepNavigationNextButton.OnClientClick = "return confirm('Are you sure you want to proceed?');";

                Button StepNavigationPreviousButton = (Button)MainWizard.FindControl("StepNavigationTemplateContainerID").FindControl("StepPreviousButton");
                StepNavigationPreviousButton.UseSubmitBehavior = false;
            }
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (MainWizard.ActiveStepIndex == 0)
            {
                Step1Box.Focus();
            }
            else if (MainWizard.ActiveStepIndex == 1)
            {
                Step2Box.Focus();
            }
            else 
            {
                Step3Box.Focus();
            }
        }
    }
}