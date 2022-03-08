<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Display.aspx.cs" Inherits="ProductWebApp.Display" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Category</asp:LinkButton>
        </p>
        <p>
            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">SubCategory</asp:LinkButton>
        </p>
        <p>
            <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">Product</asp:LinkButton>
        </p>
        <p>
            <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">Report</asp:LinkButton>
        </p>
    </form>
</body>
</html>
