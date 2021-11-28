<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddToCart.aspx.cs" Inherits="Ollibraria.View.AddToCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Style/StyleSheet.css" type="text/css" rel="stylesheet" />
    <title>Ol' Libraria - Add to Cart</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="addToCart">
            <h1>Add to Cart</h1>
            <div class="addToCartWrapper">
                <div class="btnHome">
                    <asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" />
                </div>
                <div class="gridBook">
                    <asp:GridView ID="gridBook" runat="server" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                            <asp:BoundField DataField="Stock" HeaderText="Stock" SortExpression="Stock" />
                            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                        </Columns>
                    </asp:GridView>
                </div>
                <div class="txtQuantity">
                    <asp:TextBox ID="txtQuantity" placeholder="Quantity" runat="server"></asp:TextBox>
                </div>
                <div class="lblError" style="color: red">
                    <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                </div>
                <div class="btnAddToCart">
                    <asp:Button ID="btnAddToCart" runat="server" Text="Add to Cart" OnClick="btnAddToCart_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
