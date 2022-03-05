<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="ProductWebApp.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Password1 {
            height: 13px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <h1>Product Web App</h1>
        <h3>Username<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </h3>
        <h3>Password<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </h3>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
    <p>
        &nbsp;</p>
    </form>
    </body>
</html>
