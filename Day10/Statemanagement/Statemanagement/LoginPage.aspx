<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Statemanagement.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <h2>Login Page</h2>
        <h3>Username<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </h3>
        <h3>Password<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </h3>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
    </form>
</body>
</html>
