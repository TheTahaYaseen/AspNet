using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class ValidationGroups : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RegisterLabel.Text = "Register";
                RegisterLabel.Font.Size = 36;

                RegisterNameLabel.Text = "Name";
                RegisterPasswordLabel.Text = "Password";
                RegisterConfirmPasswordLabel.Text = "Confirm Password";
                RegisterEmailLabel.Text = "Email";

                RegisterButton.Text = "Register";
                RegisterButton.ValidationGroup = "RegisterValidationGroup";

                ClearButton.Text = "Clear";
                ClearButton.CausesValidation = false;

                RegisterNameRequiredValidator.ErrorMessage = "Name is required.";
                RegisterNameRequiredValidator.Text = "*Required";
                RegisterNameRequiredValidator.ControlToValidate = "RegisterNameInput";
                RegisterNameRequiredValidator.ValidationGroup = "RegisterValidationGroup";

                RegisterEmailRequiredValidator.ErrorMessage = "Email is required.";
                RegisterEmailRequiredValidator.Text = "*Required";
                RegisterEmailRequiredValidator.ControlToValidate = "RegisterEmailInput";
                RegisterEmailRequiredValidator.Display = ValidatorDisplay.Dynamic;
                RegisterEmailRequiredValidator.ValidationGroup = "RegisterValidationGroup";

                RegisterEmailRegularExpressionValidator.ControlToValidate = "RegisterEmailInput";
                RegisterEmailRegularExpressionValidator.ErrorMessage = "Invalid Email";
                RegisterEmailRegularExpressionValidator.ValidationExpression = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                RegisterEmailRegularExpressionValidator.EnableClientScript = false;
                RegisterEmailRegularExpressionValidator.ValidationGroup = "RegisterValidationGroup";

                RegisterPasswordRequiredValidator.ErrorMessage = "Password is required.";
                RegisterPasswordRequiredValidator.Text = "*Required";
                RegisterPasswordRequiredValidator.ControlToValidate = "RegisterPasswordInput";
                RegisterPasswordRequiredValidator.Display = ValidatorDisplay.Dynamic;
                RegisterPasswordRequiredValidator.ValidationGroup = "RegisterValidationGroup";

                RegisterPasswordInput.TextMode = TextBoxMode.Password;

                RegisterConfirmPasswordRequiredValidator.ErrorMessage = "Password confirmation is required.";
                RegisterConfirmPasswordRequiredValidator.Text = "*Required";
                RegisterConfirmPasswordRequiredValidator.ControlToValidate = "RegisterConfirmPasswordInput";
                RegisterConfirmPasswordRequiredValidator.Display = ValidatorDisplay.Dynamic;
                RegisterConfirmPasswordRequiredValidator.ValidationGroup = "RegisterValidationGroup";

                RegisterConfirmPasswordInput.TextMode = TextBoxMode.Password;

                RegisterConfirmPasswordCompareValidator.ControlToValidate = "RegisterConfirmPasswordInput";
                RegisterConfirmPasswordCompareValidator.ControlToCompare = "RegisterPasswordInput";
                RegisterConfirmPasswordCompareValidator.Operator = ValidationCompareOperator.Equal;
                RegisterConfirmPasswordCompareValidator.ErrorMessage = "Password confirmation must be equal to password.";
                RegisterConfirmPasswordCompareValidator.ValidationGroup = "RegisterValidationGroup";

                RegistrationValidationSummary.HeaderText = "Error Messages";
                RegistrationValidationSummary.ForeColor = Color.Maroon;
                RegistrationValidationSummary.DisplayMode = ValidationSummaryDisplayMode.List;
                RegistrationValidationSummary.ValidationGroup = "RegisterValidationGroup";

                LoginLabel.Text = "Login";
                LoginLabel.Font.Size = 36;

                LoginPasswordLabel.Text = "Password";
                LoginEmailLabel.Text = "Email";

                LoginButton.Text = "Login";
                LoginButton.ValidationGroup = "LoginValidationGroup";

                LoginEmailRequiredValidator.ErrorMessage = "Email is required.";
                LoginEmailRequiredValidator.Text = "*Required";
                LoginEmailRequiredValidator.ControlToValidate = "LoginEmailInput";
                LoginEmailRequiredValidator.Display = ValidatorDisplay.Dynamic;
                LoginEmailRequiredValidator.ValidationGroup = "LoginValidationGroup";

                LoginEmailRegularExpressionValidator.ControlToValidate = "LoginEmailInput";
                LoginEmailRegularExpressionValidator.ErrorMessage = "Invalid Email";
                LoginEmailRegularExpressionValidator.ValidationExpression = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                LoginEmailRegularExpressionValidator.EnableClientScript = false;
                LoginEmailRegularExpressionValidator.ValidationGroup = "LoginValidationGroup";

                LoginPasswordRequiredValidator.ErrorMessage = "Password is required.";
                LoginPasswordRequiredValidator.Text = "*Required";
                LoginPasswordRequiredValidator.ControlToValidate = "LoginPasswordInput";
                LoginPasswordRequiredValidator.Display = ValidatorDisplay.Dynamic;
                LoginPasswordRequiredValidator.ValidationGroup = "LoginValidationGroup";

                LoginPasswordInput.TextMode = TextBoxMode.Password;

                LoginValidationSummary.HeaderText = "Error Messages";
                LoginValidationSummary.ForeColor = Color.Maroon;
                LoginValidationSummary.DisplayMode = ValidationSummaryDisplayMode.List;
                LoginValidationSummary.ValidationGroup = "LoginValidationGroup";
            }
        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                RegistrationStatusLabel.ForeColor = Color.RoyalBlue;
                RegistrationStatusLabel.Text = "Data saved successfully.";
            }
            else
            {
                RegistrationStatusLabel.ForeColor = Color.Maroon;
                RegistrationStatusLabel.Text = "Data not saved due to incomplete details.";
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                LoginStatusLabel.ForeColor = Color.RoyalBlue;
                LoginStatusLabel.Text = "Data saved successfully.";
            }
            else
            {
                LoginStatusLabel.ForeColor = Color.Maroon;
                LoginStatusLabel.Text = "Data not saved due to incomplete details.";
            }
        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {
            RegisterNameInput.Text = "";
            RegisterEmailInput.Text = "";
            RegisterPasswordInput.Text = "";
            RegisterConfirmPasswordInput.Text = "";
        }
    }
}