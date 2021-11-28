<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Ollibraria.View.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Style/StyleSheet.css" type="text/css" rel="stylesheet" />
    <title>Ol' Libraria - Register</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="register">
            <h1>Register</h1>
            <div class="registerWrapper">
                <div class="txtInput">
                    <asp:TextBox ID="txtUsername" placeholder="Username" runat="server"></asp:TextBox>
                </div>
                <div class="txtInput">
                    <asp:TextBox ID="txtPassword" placeholder="Password" runat="server" TextMode="Password"></asp:TextBox>
                </div>
                <div class="txtInput">
                    <asp:TextBox ID="txtConfirmPassword" placeholder="Confirm Password" runat="server" TextMode="Password"></asp:TextBox>
                </div>
                <div class="txtInput">
                    <asp:TextBox ID="txtName" placeholder="Name" runat="server"></asp:TextBox>
                </div>
                <div class="radioGender">
                    <asp:Label ID="lblGender" runat="server" Text="Gender "></asp:Label>
                    <asp:RadioButton ID="radioMale" runat="server" GroupName="Gender" Text="Male" />
                    <asp:RadioButton ID="radioFemale" runat="server" GroupName="Gender" Text="Female" />
                </div>
                <div class="txtInput">
                    <asp:TextBox ID="txtPhone" placeholder="Phone Number" runat="server"></asp:TextBox>
                </div>
                <div class="txtInput">
                    <asp:TextBox ID="txtAddress" placeholder="Address" runat="server" TextMode="MultiLine" Rows="5"></asp:TextBox>
                </div>
                <div class="lblError" style="color: red">
                    <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                </div>
                <div class="btnRegister">
                    <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click"/>
                </div>
                <div class="toLogin">
                    <asp:LinkButton ID="btnRedirectToLogin" runat="server" OnClick="btnRedirectToLogin_Click">Already have an account? Login now!</asp:LinkButton>
                </div>
            </div>
            
        </div>
        
    </form>
</body>
</html>
