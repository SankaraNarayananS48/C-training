<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomGrid.aspx.cs" Inherits="CustomGridCRUD.CustomGrid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <h2>Grid View CRUD Operation</h2>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting1">
            <Columns>
                <asp:TemplateField HeaderText="RollNo">
                    <ItemTemplate>
                        <asp:Label ID="rollnolabel" runat="server" Text='<%#Bind("RollNo") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="rollnotbox" runat="server" Text='<%#Bind("RollNo") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <asp:Label ID="namelabel" runat="server" Text='<%#Bind("Name") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="nametbox" runat="server" Text='<%#Bind("Name") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Phoneno">
                    <ItemTemplate>
                        <asp:Label ID="phonenolabel" runat="server" Text='<%#Bind("Phoneno") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="phonenotbox" runat="server" Text='<%#Bind("Phoneno") %>'></asp:TextBox>
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
    </form>
</body>
</html>
