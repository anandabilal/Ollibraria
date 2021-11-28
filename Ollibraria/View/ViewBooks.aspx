<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewBooks.aspx.cs" Inherits="Ollibraria.View.ViewBooks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Style/StyleSheet.css" type="text/css" rel="stylesheet" />
    <title>Ol' Libraria - View Books</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="viewBooks">
            <h1>View Books</h1>
            <div class="viewBooksWrapper">
                <div class="btnHome">
	                <asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" />
                </div>
                <div class="txtBtnSearchShowAll">
                    <asp:TextBox ID="txtSearch" placeholder="Search" runat="server" Text=""></asp:TextBox>
                    <asp:Button ID="btnSearch" runat="server" Text="Search Book" OnClick="btnSearch_Click" />
                    <asp:Button ID="btnShowAll" runat="server" Text="Show All" />
                </div>
                <div class="gridBook">
                    <asp:GridView ID="gridBook" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanging="gridBook_SelectedIndexChanging" OnRowDeleting="gridBook_RowDeleting" OnRowEditing="gridBook_RowEditing">
                        <Columns>
                            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                            <asp:BoundField DataField="Stock" HeaderText="Stock" SortExpression="Stock" />
                            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Action" ShowHeader="True" Text="Add to Cart" />
                            <asp:CommandField ButtonType="Button" HeaderText="Admin Actions" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
                        </Columns>
                    </asp:GridView>
                </div>
                <div class="btnInsert">
                    <asp:Button ID="btnInsert" runat="server" Text="Insert Book" OnClick="btnInsert_Click" />
                </div>
            </div>
            
        </div>
        
    </form>
</body>
</html>
