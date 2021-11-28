<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Ollibraria.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Style/StyleSheet.css" type="text/css" rel="stylesheet" />
    <title>Ol' Libraria - Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login">
            <h1>Login</h1>
            <div class="loginWrapper">
                <div class="txtInput">
                    <asp:TextBox ID="txtUsername" placeholder="Username" runat="server"></asp:TextBox>
                </div>
                <div class="txtInput">
                    <asp:TextBox ID="txtPassword" placeholder="Password" runat="server" TextMode="Password"></asp:TextBox>
                </div>
                <div class="rememberMe">
                    <asp:CheckBox ID="checkRememberMe" runat="server" Text="Remember Me"></asp:CheckBox>
                </div>
                <div class="lblError" style="color: red">
                    <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                </div>
                <div class="btnLogin">
                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/>
                </div>
                <div class="toRegister">
                    <asp:LinkButton ID="btnRedirectToRegister" runat="server" OnClick="btnRedirectToRegister_Click">Don't have an account? Register now!</asp:LinkButton>
                </div>
            </div>
        </div>
    </form>
</body>
</html>