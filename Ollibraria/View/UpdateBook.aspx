<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateBook.aspx.cs" Inherits="Ollibraria.View.UpdateBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Style/StyleSheet.css" type="text/css" rel="stylesheet" />
    <title>Ol' Libraria - Update Book</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="updateBook">
            <h1>Update Book</h1>
            <div class="updateBookWrapper">
                <div class="btnHome">
	                <asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" />
                </div>
                <div class="txtName">
                    <asp:TextBox ID="txtName" placeholder="Name" runat="server"></asp:TextBox>
                </div>
                <div class="txtDescription">
                    <asp:TextBox ID="txtDescription" placeholder="Description" runat="server" TextMode="MultiLine" Rows="5"></asp:TextBox>
                </div>
                <div class="txtStock">
                    <asp:TextBox ID="txtStock" placeholder="Stock" runat="server"></asp:TextBox>
                </div>
                <div class="txtPrice">
                    <asp:TextBox ID="txtPrice" placeholder="Price" runat="server"></asp:TextBox>
                </div>
                <div class="lblError" style="color: red">
                    <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                </div>
                <div class="btnUpdate">
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
