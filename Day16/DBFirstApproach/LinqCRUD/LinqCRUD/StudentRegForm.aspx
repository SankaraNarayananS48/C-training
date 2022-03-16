<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRegForm.aspx.cs" Inherits="LinqCRUD.StudentRegForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
       <center><h2>Student Registration CRUD Operation</h2></center> 
        <br /><br />
        <fieldset>
            <legend>Student Information</legend>
            <h3>Id     <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </h3>
            <h3>Name    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </h3>
            <h3>Phoneno  <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </h3>
        
        <br />
        <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" />
        <asp:Button ID="Button4" runat="server" Text="Display" OnClick="Button4_Click" />
        <br /><br />
        </fieldset>
        <asp:GridView ID="GridView1" runat="server" BackColor="Black" BorderColor="#000066" BorderStyle="Dashed" ForeColor="White">
        </asp:GridView>
    </form>
</body>
</html>
