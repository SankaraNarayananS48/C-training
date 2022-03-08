<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="ProductWebApp.Category" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <h1>Category Form</h1>
        <h3>Category id<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </h3>
        <h3>Category name<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </h3>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="View" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
