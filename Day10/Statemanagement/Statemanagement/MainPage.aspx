<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="Statemanagement.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <h2>CRUD Operations</h2>
        <h3>Category Id<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </h3>
        <h3>Category Name<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </h3>
        <p>&nbsp;</p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
            <Columns>
                <asp:TemplateField HeaderText="CategoryId">
                    <ItemTemplate>
                        <asp:Label ID="catidlabel" runat="server" Text='<%#Bind("catid") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID ="catidtbox" runat="server" Text='<%#Bind("catid") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="CategoryName">
                    <ItemTemplate>
                        <asp:Label ID="catnamelabel" runat="server" Text='<%#Bind("catname") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID ="catnametbox" runat="server" Text='<%#Bind("catname") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Edit">
                    <ItemTemplate>
                        <asp:LinkButton ID="editlink" runat="server" Text="Edit" CommandName="Edit"></asp:LinkButton>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:LinkButton ID="cancellink" runat="server" Text="Cancel" CommandName="Cancel"></asp:LinkButton>
                        <asp:LinkButton ID="updatelink" runat="server" Text="Update" CommandName="Update"></asp:LinkButton>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete">
                    <ItemTemplate>
                        <asp:LinkButton ID="deletelink" runat="server" Text="Delete" CommandName="Delete"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" />
        <asp:Button ID="Button2" runat="server" Text="Display" OnClick="Button2_Click" />
    </form>
</body>
</html>
         
