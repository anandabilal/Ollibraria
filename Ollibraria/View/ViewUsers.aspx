<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewUsers.aspx.cs" Inherits="Ollibraria.View.ViewUsers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Style/StyleSheet.css" type="text/css" rel="stylesheet" />
    <title>Ol' Libraria - View Users</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="viewUsers">
            <h1>Users</h1>
            <div class="viewUsersWrapper">
                <div class="btnHome">
	                <asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" />
                </div>
                <div class="gridUser">
                    <asp:GridView ID="gridUser" runat="server" AutoGenerateColumns="False" OnRowDeleting="gridUser_RowDeleting">
                        <Columns>
                            <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
                            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                            <asp:BoundField DataField="Role.RoleName" HeaderText="Role" SortExpression="Role.RoleName" />
                            <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                            <asp:BoundField DataField="PhoneNumber" HeaderText="Phone Number" SortExpression="PhoneNumber" />
                            <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                            <asp:CommandField ButtonType="Button" HeaderText="Admin Action" ShowDeleteButton="True" ShowHeader="True" />
                        </Columns>     
                    </asp:GridView>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
