<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCart.aspx.cs" Inherits="Ollibraria.View.ViewCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Style/StyleSheet.css" type="text/css" rel="stylesheet" />
    <title>Ol' Libraria - View Cart</title>
    <style type="text/css">
        .auto-style1 {
            height: 22px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="viewCart">
            <h1>View Cart</h1>
            <div class="viewCartWrapper">
                <div class="btnHomeViewBook">
                    <asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" />
                    <asp:Button ID="btnViewBook" runat="server" Text="View Books" OnClick="btnViewBook_Click" />
                </div>
                <div class="tableCart">
                    <table ID="tableCart" style="width: 100%;" border="1">
                        <tr>
                            <th>Book Name</th>
                            <th>Price</th>
                            <th>Quantity</th>
                            <th>Sub Total</th>
                        </tr>
                
                        <% foreach (var c in cart)
                           { %>
                            <tr>
                                <td class="auto-style1"><%= c.Book.Name %></td>
                                <td class="auto-style1"><%= c.Book.Price %></td>
                                <td class="auto-style1"><%= c.Quantity %></td>
                                <td class="auto-style1"><%= c.Book.Price * c.Quantity %></td>
                            </tr>
                        <% } %>
                    
                        <tr>
                            <td ID="grandTotal" colspan="3">Grand Total</td>
                            <td><%= cart.Sum(total => total.Book.Price * total.Quantity) %></td>
                        </tr>
                    </table>
                </div>
                <div class="lblError" style="color: red">
                    <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                </div>
                <div class="btnCheckout">
                    <asp:Button ID="btnCheckout" runat="server" Text="Checkout" OnClick="btnCheckout_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
