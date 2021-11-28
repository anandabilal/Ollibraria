<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Ollibraria.View.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Style/StyleSheet.css" type="text/css" rel="stylesheet" />
    <title>Ol' Libraria - Home</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="home">
            <h1>Home</h1>
            <div class="homeWrapper">
                <div class="lblWelcome">
                    <asp:Label ID="lblWelcome" runat="server" Text=""></asp:Label>
                </div>
                <div class="btnBookProfile">
                    <asp:Button ID="btnBook" runat="server" Text="View Books" OnClick="btnBook_Click" />
                    <asp:Button ID="btnProfile" runat="server" Text="View Profile" OnClick="btnProfile_Click" />
                </div>
                <div class="btnViewCartTransactionHistory">
                    <asp:Button ID="btnViewCart" runat="server" Text="View Cart" OnClick="btnViewCart_Click" />
                    <asp:Button ID="btnTransactionHistory" runat="server" Text="View Transaction History" OnClick="btnTransactionHistory_Click" />
                </div>
                <div class="btnInsertBookViewUsersTransactionReport">
                    <asp:Button ID="btnInsertBook" runat="server" Text="Insert Book" OnClick="btnInsertBook_Click" />
                    <asp:Button ID="btnViewUsers" runat="server" Text="View Users" OnClick="btnViewUsers_Click" />
                    <asp:Button ID="btnTransactionReport" runat="server" Text="View Transaction Report Page" OnClick="btnTransactionReport_Click" />
                </div>
                <div class="btnLogout">
                    <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
                </div>
            </div>
     
        </div>
        
    </form>
</body>
</html>
