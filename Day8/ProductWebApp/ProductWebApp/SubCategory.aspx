<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SubCategory.aspx.cs" Inherits="ProductWebApp.SubCategory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <h1>Sub-Category page</h1>
        <h3>CategoryId<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </h3>
        <h3>SubCategoryId<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </h3>
        <h3>SubCategoryName<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </h3>
        <asp:Button ID="Button1" runat="server" Height="28px" OnClick="Button1_Click" Text="Insert" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="View" />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
