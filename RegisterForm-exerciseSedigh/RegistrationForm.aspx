<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RegistrationForm.aspx.cs" Inherits="RegistrationForm" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table border="0">
        <tr>
            <td style="width: 150px">
                <asp:Label ID="lblUserName" runat="server" Text="UserName"></asp:Label>
            </td>
            <td style="width: 400px">
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            </td>
            <td style="width: 50px">
                <asp:RequiredFieldValidator ID="rfvUserName" runat="server"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revUserName" runat="server"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">
                <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            </td>
            <td style="width: 400px">
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td style="width: 50px">
                <asp:RequiredFieldValidator ID="rfvTxtPassword" runat="server"></asp:RequiredFieldValidator>

            </td>
        </tr>

        <tr>
            <td style="width: 150px">
                <asp:Label ID="lblConfirmPassword" runat="server" Text="Password"></asp:Label>
            </td>
            <td style="width: 400px">
                <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td style="width: 50px">
                <asp:RequiredFieldValidator ID="rfvTxtConfirmPassword" runat="server"></asp:RequiredFieldValidator>
                <%--<asp:CompareValidator ID="cpvTxtConfirmPassword" runat="server"></asp:CompareValidator>--%>
            </td>
        </tr>

        <tr>
            <td colspan="3">
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </td>
        </tr>

    </table>
</asp:Content>

