using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class ReqiredValidatorControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                NameLabel.Text = "Name";
                GenderLabel.Text = "Gender";
                AgeLabel.Text = "Even Age";
                DateLabel.Text = "Date";
                PasswordLabel.Text = "Password";
                ConfirmPasswordLabel.Text = "Confirm Password";
                EmailLabel.Text = "Email";

                SaveButton.Text = "Save";

                NameRequiredValidator.ErrorMessage = "Name is required.";
                NameRequiredValidator.Text = "*Required";
                NameRequiredValidator.ControlToValidate = "NameInput";

                EmailRequiredValidator.ErrorMessage = "Email is required.";
                EmailRequiredValidator.Text = "*Required";
                EmailRequiredValidator.ControlToValidate = "EmailInput";
                EmailRequiredValidator.Display = ValidatorDisplay.Dynamic;

                EmailRegularExpressionValidator.ControlToValidate = "EmailInput";
                EmailRegularExpressionValidator.ErrorMessage = "Invalid Email";
                EmailRegularExpressionValidator.ValidationExpression = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                EmailRegularExpressionValidator.EnableClientScript = false;

                AgeRequiredValidator.ErrorMessage = "Age is required.";
                AgeRequiredValidator.Text = "*Required";
                AgeRequiredValidator.ControlToValidate = "AgeInput";
                AgeRequiredValidator.Display = ValidatorDisplay.Dynamic;

                AgeRangeValidator.ControlToValidate = "AgeInput";
                AgeRangeValidator.MinimumValue = "18";
                AgeRangeValidator.MaximumValue = "75";
                AgeRangeValidator.ErrorMessage = "Age must be between 18 - 75";
                AgeRangeValidator.Display = ValidatorDisplay.Dynamic;

                AgeCompareValidator.ControlToValidate = "AgeInput";
                AgeCompareValidator.Type = ValidationDataType.Integer;
                AgeCompareValidator.Operator = ValidationCompareOperator.DataTypeCheck;
                AgeCompareValidator.ErrorMessage = "Age must be an integer.";

                EvenAgeCustomValidator.ControlToValidate = "AgeInput";
                EvenAgeCustomValidator.ValidateEmptyText = true;
                EvenAgeCustomValidator.ErrorMessage = "Age is not an even number";
                EvenAgeCustomValidator.ClientValidationFunction = "IsEven";

                PasswordRequiredValidator.ErrorMessage = "Password is required.";
                PasswordRequiredValidator.Text = "*Required";
                PasswordRequiredValidator.ControlToValidate = "PasswordInput";
                PasswordRequiredValidator.Display = ValidatorDisplay.Dynamic;

                PasswordInput.TextMode = TextBoxMode.Password;

                ConfirmPasswordRequiredValidator.ErrorMessage = "Password confirmation is required.";
                ConfirmPasswordRequiredValidator.Text = "*Required";
                ConfirmPasswordRequiredValidator.ControlToValidate = "ConfirmPasswordInput";
                ConfirmPasswordRequiredValidator.Display = ValidatorDisplay.Dynamic;

                ConfirmPasswordInput.TextMode = TextBoxMode.Password;

                ConfirmPasswordCompareValidator.ControlToValidate = "ConfirmPasswordInput";
                ConfirmPasswordCompareValidator.ControlToCompare = "PasswordInput";
                ConfirmPasswordCompareValidator.Operator = ValidationCompareOperator.Equal;
                ConfirmPasswordCompareValidator.ErrorMessage = "Password confirmation must be equal to password.";

                DateRequiredValidator.ErrorMessage = "Date is required.";
                DateRequiredValidator.Text = "*Required";
                DateRequiredValidator.ControlToValidate = "DateInput";
                DateRequiredValidator.Display = ValidatorDisplay.Dynamic;

                DateRangeValidator.ControlToValidate = "DateInput";
                DateRangeValidator.MinimumValue = "2023-01-01";
                DateRangeValidator.MaximumValue = "2023-12-31";
                DateRangeValidator.ErrorMessage = "Date must be between 01/01/2023 - 31/12/2023";
                DateRangeValidator.Type = ValidationDataType.Date;
                DateRangeValidator.Display = ValidatorDisplay.Dynamic;

                DateCompareValidator.ControlToValidate = "DateInput";
                DateCompareValidator.ValueToCompare = "2023-05-31";
                DateCompareValidator.Operator = ValidationCompareOperator.GreaterThan;
                DateCompareValidator.ErrorMessage = "Date must of 6th month or ahead.";

                GenderRequiredValidator.ErrorMessage = "Gender is required.";
                GenderRequiredValidator.Text = "*Required";
                GenderRequiredValidator.ControlToValidate = "GenderInput";
                GenderRequiredValidator.InitialValue = "-1";

                ValidationSummary.HeaderText = "Error Messages";
                ValidationSummary.ForeColor = Color.Maroon;
                ValidationSummary.ShowMessageBox = true;
                ValidationSummary.ShowSummary = true;
                ValidationSummary.DisplayMode = ValidationSummaryDisplayMode.List;

                ListItem GenderBrick = new ListItem("Select Gender", "-1");
                ListItem GenderBrickMale = new ListItem("Male", "1");
                ListItem GenderBrickFemale = new ListItem("Female", "2");

                GenderInput.Items.Add(GenderBrick);
                GenderInput.Items.Add(GenderBrickMale);
                GenderInput.Items.Add(GenderBrickFemale);
            }
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                StatusLabel.ForeColor = Color.RoyalBlue;
                StatusLabel.Text = "Data saved successfully.";
            }
            else
            {
                StatusLabel.ForeColor = Color.Maroon;
                StatusLabel.Text = "Data not saved due to incomplete details.";
            }
        }

        protected void EvenAgeCustomValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value == "")
            {
                args.IsValid = false;
            }
            else
            {
                int Number;
                bool IsNumber = int.TryParse(args.Value, out Number);

                if(IsNumber && Number >= 0 && Number % 2 == 0)
                {
                    args.IsValid = true;
                }
                else
                {
                        args.IsValid = false;
                }
            }
        }
    }
}