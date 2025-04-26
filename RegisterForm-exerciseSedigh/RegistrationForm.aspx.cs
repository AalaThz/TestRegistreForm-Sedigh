using System;

public partial class RegistrationForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, System.EventArgs e)
    {
        if (!IsPostBack)
            Inisialize();
        lblMessage.Visible = false;
    }

    private void Inisialize()
    {
        MyWebApp.Utilities.SetRequiredFieldValidator(rfvUserName, txtUserName, lblUserName.Text);
        MyWebApp.Utilities.SetRequiredFieldValidator(rfvTxtPassword, txtPassword, lblPassword.Text);
        MyWebApp.Utilities.SetRequiredFieldValidator(rfvTxtConfirmPassword, txtConfirmPassword, lblPassword.Text);
        MyWebApp.Utilities.SetRegularExpressionValidator(revUserName, txtUserName,lblUserName.Text,MyWebApp.RegularExpressions.UserName);
    }

    protected void btnSave_Click(object sender, System.EventArgs e)
    {
        if (Page.IsValid)
        {
            lblMessage.Text = "Your Information is : .....";
            lblMessage.Visible = true;
        }
    }


}