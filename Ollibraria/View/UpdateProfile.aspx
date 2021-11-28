<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="Ollibraria.View.UpdateProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Style/StyleSheet.css" type="text/css" rel="stylesheet" />
    <title>Ol' Libraria - Update Profile</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="updateProfile">
            <h1>Update Profile</h1>
            <div class="updateProfileWrapper">
                <div class="btnHome">
	                <asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" />
                </div>
                <div class="txtName">
                    <asp:TextBox ID="txtName" placeholder="Name" runat="server"></asp:TextBox>
                </div>
                <div class="lblGender">
                    <asp:Label ID="lblGender" runat="server" Text="Gender "></asp:Label>
                    <asp:RadioButton ID="radioMale" runat="server" GroupName="Gender" Text="Male" />
                    <asp:RadioButton ID="radioFemale" runat="server" GroupName="Gender" Text="Female" />
                </div>
                <div class="txtPhone">
                    <asp:TextBox ID="txtPhone" placeholder="Phone Number" runat="server"></asp:TextBox>
                </div>
                <div class="txtAddress">
                    <asp:TextBox ID="txtAddress" placeholder="Address" runat="server" TextMode="MultiLine" Rows="5"></asp:TextBox>
                </div>
                <div class="lblError" style="color: red">
                    <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                </div>
                <div class="btnUpdate">
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click"/>
                </div>
            </div>
        </div>
        
        
    </form>
</body>
</html>
