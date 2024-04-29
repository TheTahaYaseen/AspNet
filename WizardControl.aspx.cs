using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class WizardControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                bool SomeCondition = false;

                if (SomeCondition)
                {
                    MainWizard.ActiveStepIndex = 2;
                }
                MainWizard.DisplayCancelButton = true;
                MainWizard.CancelButtonText = "Visit me then";
                MainWizard.CancelDestinationPageUrl = "https://thetahayaseen.pythonanywhere.com";

                MainWizard.DisplaySideBar = true;

                MainWizard.FinishCompleteButtonType = ButtonType.Link;
                MainWizard.FinishPreviousButtonText = "Back";

                MainWizard.HeaderStyle.ForeColor = Color.White;
                MainWizard.HeaderStyle.BackColor = Color.Black;

                MainWizard.SideBarStyle.ForeColor = Color.White;
                MainWizard.SideBarStyle.BackColor = Color.Black;

                MainWizard.NavigationStyle.BackColor = Color.Black;
                MainWizard.NavigationStyle.ForeColor = Color.White;

                MainWizard.StepNextButtonText = "Proceed";
                MainWizard.StepPreviousButtonText = "Backwards";

                MainWizard.StepStyle.BackColor = Color.CornflowerBlue;
                MainWizard.StepStyle.ForeColor = Color.AntiqueWhite;
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            switch (MainWizard.ActiveStepIndex)
            {
                case 0:
                    MainWizard.HeaderText = "Personal Details";
                    break;
                case 1:
                    MainWizard.HeaderText = "Contact Details";
                    break;
                case 2:
                    MainWizard.HeaderText = "Summary";
                    break;
            }

        }

        protected void MainWizard_NextButtonClick(object sender, WizardNavigationEventArgs e)
        {
            if(e.NextStepIndex == 2)
            {
                SummaryFirstName.Text = FirstNameInput.Text;
                SummaryLastName.Text = LastNameInput.Text;
                SummaryGender.Text = GenderInput.SelectedItem.Text;
                SummaryEmail.Text = EmailInput.Text;
                SummaryContact.Text = ContactInput.Text;
            }

            Response.Write("Current step index is " + e.CurrentStepIndex.ToString());
            Response.Write("Next step index is " + e.NextStepIndex.ToString());
            e.Cancel = CancelNavigation.Checked;
        }

        protected void MainWizard_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            Response.Redirect("~/AdRotator.aspx");
        }

        protected void MainWizard_ActiveStepChanged(object sender, EventArgs e)
        {
            Response.Write("Active step changed to " + MainWizard.ActiveStep.Title);
        }

        protected void MainWizard_CancelButtonClick(object sender, EventArgs e)
        {
            Response.Write("Operation cancelled!");
        }

        protected void MainWizard_PreviousButtonClick(object sender, WizardNavigationEventArgs e)
        {
            Response.Write("Current step index is " + e.CurrentStepIndex.ToString());
            Response.Write("Next step index is " + e.NextStepIndex.ToString());
            e.Cancel = CancelNavigation.Checked;
        }

        protected void MainWizard_SideBarButtonClick(object sender, WizardNavigationEventArgs e)
        {
            Response.Write("Current step index is " + e.CurrentStepIndex.ToString());
            Response.Write("Next step index is " + e.NextStepIndex.ToString());
            e.Cancel = CancelNavigation.Checked;
        }
    }
}