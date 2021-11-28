<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="Ollibraria.View.ChangePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Style/StyleSheet.css" type="text/css" rel="stylesheet" />
    <title>Ol' Libraria - Change Password</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="changePassword">
            <h1>Change Password</h1>
            <div class="changePasswordWrapper">
                <div class="btnHome">
                    <asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" />
                </div>
                <div class="txtOldPassword">
                    <asp:TextBox ID="txtOldPassword" placeholder="Old Password" runat="server" TextMode="Password"></asp:TextBox>
                </div>
                <div class="txtNewPassword">
                    <asp:TextBox ID="txtNewPassword" placeholder="New Password" runat="server" TextMode="Password"></asp:TextBox>
                </div>
                <div class="txtConfirmPassword">
                    <asp:TextBox ID="txtConfirmPassword" placeholder="Confirm Password" runat="server" TextMode="Password"></asp:TextBox>
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
