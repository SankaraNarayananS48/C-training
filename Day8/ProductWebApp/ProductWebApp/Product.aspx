<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="ProductWebApp.Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <h1>Product Form</h1>
        <h3>Category id<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </h3>
        <h3>SubCategory id<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </h3>
        <h3>Product id<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </h3>
        <h3>Product Name<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </h3>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="View" />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
