<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertBook.aspx.cs" Inherits="Ollibraria.View.InsertBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Style/StyleSheet.css" type="text/css" rel="stylesheet" />
    <title>Ol' Libraria - Insert Book</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="insertBook">
            <h1>Insert Book</h1>
            <div class="insertBookWrapper">
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
                <div class="btnInsert">
                    <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
                </div>
            </div>
            
        </div>
        
    </form>
</body>
</html>
