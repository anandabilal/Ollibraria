<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewTransactionHistory.aspx.cs" Inherits="Ollibraria.View.ViewTransactionHistory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Style/StyleSheet.css" type="text/css" rel="stylesheet" />
    <title>Ol' Libraria - View Transaction History</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="viewTransactionHistory">
            <h1>Transaction History</h1>
            <div class="viewTransactionHistoryWrapper">
                <div class="btnHome">
	                <asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" />
                </div>
                <div class="tableHistory">
                    <table ID="tableHistory" style="width: 100%;" border="1">
                        <tr>
                            <th>Book Name</th>
                            <th>Quantity</th>
                            <th>Date</th>
                            <th>Sub Total</th>
                        </tr>
                
                        <% foreach (var d in dt)
                           { %>
                            <tr>
                                <td class="auto-style1"><%= d.Book.Name %></td>
                                <td class="auto-style1"><%= d.Quantity %></td>
                                <td class="auto-style1"><%= d.HeaderTransaction.TransactionDate %></td>
                                <td class="auto-style1"><%= d.Book.Price * d.Quantity %></td>
                            </tr>
                        <% } %>
                    
                        <tr>
                            <td ID="grandTotal" colspan="3">Grand Total</td>
                            <td><%= dt.Sum(total => total.Book.Price * total.Quantity) %></td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
