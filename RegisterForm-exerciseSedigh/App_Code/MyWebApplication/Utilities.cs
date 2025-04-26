namespace MyWebApp
{
    public static class Utilities
    {
        public static void SetRequiredFieldValidator(
            System.Web.UI.WebControls.RequiredFieldValidator validator,
            System.Web.UI.Control controlToValidate,
            string controlCaption
            )
        {
            SetRequiredFieldValidator(validator, controlToValidate, controlCaption, "");
        }

        public static void SetRequiredFieldValidator(
            System.Web.UI.WebControls.RequiredFieldValidator validator,
            System.Web.UI.Control controlToValidate,
            string controlCaption,
            string validationGroup
            )
        {
            validator.ControlToValidate = controlToValidate.ID;
            validator.InitialValue = "";
            validator.ValidationGroup = validationGroup;
            validator.SetFocusOnError = true;
            validator.EnableClientScript = true;
            validator.ErrorMessage = $"You did not Specify {controlCaption}";
            validator.ToolTip = validator.ErrorMessage;
            validator.Text = "*";
            validator.Display = System.Web.UI.WebControls.ValidatorDisplay.Dynamic;
            validator.CssClass = "Validator";
            validator.Visible = true;
            validator.Enabled = true;
            validator.EnableViewState = true;

        }


        public static void SetRegularExpressionValidator(
            System.Web.UI.WebControls.RegularExpressionValidator validator,
              System.Web.UI.Control controlToValidate,
              string controlCaption,
              RegularExpressions regularExpressions
            )
        {
            SetRegularExpressionValidator(validator, controlToValidate, controlCaption,regularExpressions,"");
        }
        public static void SetRegularExpressionValidator(
            System.Web.UI.WebControls.RegularExpressionValidator validator,
              System.Web.UI.Control controlToValidate,
              string controlCaption,
              RegularExpressions regularExpressions,
              string validationGroup
            )
        {
            switch (regularExpressions)
            {
                case RegularExpressions.Url:
                    break;
                case RegularExpressions.MobileNumber:
                    break;
                case RegularExpressions.IDCard:
                    break;
                case RegularExpressions.Time:
                    break;
                case RegularExpressions.Date:
                    break;
                case RegularExpressions.DateTime:
                    break;
                case RegularExpressions.Email:
                    
                    break;
                case RegularExpressions.Password:
                    validator.ValidationExpression = @"[\d_a-zA-Z0-9]{8,14}";
                    validator.ErrorMessage = "[a-z] [A-Z] [0-9] - Length 8 to 14";
                    break;
                case RegularExpressions.UserName:
                    validator.ValidationExpression = @"[\d_a-zA-Z0-9]{8,14}";
                    validator.ErrorMessage = "[a-z] [A-Z] [0-9] - Length 8 to 14";
                    break;
                default:
                    break;
            }


            validator.Text = "*";
            validator.ToolTip = validator.ErrorMessage;
            validator.Visible = true;
            validator.Enabled = true;
            validator.CssClass = "Validator";
            validator.EnableViewState = true;
            validator.SetFocusOnError = true;
            validator.EnableClientScript = true;
            validator.ValidationGroup = validationGroup;
            validator.ControlToValidate = controlToValidate.ID;
            validator.Display = System.Web.UI.WebControls.ValidatorDisplay.Dynamic;
        }
    }
}