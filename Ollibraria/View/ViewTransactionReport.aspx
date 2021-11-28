<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewTransactionReport.aspx.cs" Inherits="Ollibraria.View.ViewTransactionReport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Style/StyleSheet.css" type="text/css" rel="stylesheet" />
    <title>Ol' Libraria - View Transaction Report</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="viewTransactionReport">
            <h1>Transaction Report</h1>
            <div class="viewTransactionReportWrapper">
                <div class="btnHome">
	                <asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" />
                </div>
                <div class="divTableReport">
                    <table ID="tableReport" style="width: 100%;" border="1">
                        <tr>
                            <th>Transaction ID</th>
                            <th>User ID</th>
                            <th>User Name</th>
                            <th>Book ID</th>
                            <th>Book Name</th>
                            <th>Date</th>
                            <th>Price</th>
                            <th>Quantity</th>
                            <th>Sub Total</th>
                        </tr>
                
                        <% foreach (var d in dt)
                           { %>
                            <tr>
                                <td class="auto-style1"><%= d.TransactionId %></td>
                                <td class="auto-style1"><%= d.HeaderTransaction.UserId %></td>
                                <td class="auto-style1"><%= d.HeaderTransaction.User.Name %></td>
                                <td class="auto-style1"><%= d.BookId %></td>
                                <td class="auto-style1"><%= d.Book.Name %></td>
                                <td class="auto-style1"><%= d.HeaderTransaction.TransactionDate %></td>
                                <td class="auto-style1"><%= d.Book.Price %></td>
                                <td class="auto-style1"><%= d.Quantity %></td>
                                <td class="auto-style1"><%= d.Book.Price * d.Quantity %></td>
                            </tr>
                        <% } %>
                    
                        <tr>
                            <td id="grandTotal" colspan="8">Grand Total</td>
                            <td><%= dt.Sum(total => total.Book.Price * total.Quantity) %></td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
