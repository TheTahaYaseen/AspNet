using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class MultiViewModal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MultiViewEmployeeForm.ActiveViewIndex = 0;
        }

        protected void ProceedToContactButton_Click(object sender, EventArgs e)
        {
            MultiViewEmployeeForm.ActiveViewIndex = 1;
        }

        protected void ProceedToSummaryButton_Click(object sender, EventArgs e)
        {
            MultiViewEmployeeForm.ActiveViewIndex = 2;
            SummaryFirstName.Text = FirstNameInput.Text;
            SummaryLastName.Text = LastNameInput.Text;
            SummaryGender.Text = GenderInput.SelectedItem.Text;
            SummaryEmail.Text = EmailInput.Text;
            SummaryContact.Text = ContactInput.Text;
        }

        protected void FinishButton_Click(object sender, EventArgs e)
        {
            MultiViewEmployeeForm.ActiveViewIndex = 3;
            Response.Write("Employee added successfully.");
        }
    }
}