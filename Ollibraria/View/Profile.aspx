<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Ollibraria.View.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Style/StyleSheet.css" type="text/css" rel="stylesheet" />
    <title>Ol' Libraria - Profile</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="profile">
            <h1>Profile</h1>
            <div class="profileWrapper">
                <div class="btnHome">
	                <asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" />
                </div>
                <div class="gridProfile">
                    <asp:GridView ID="gridProfile" runat="server" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
                            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                            <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                            <asp:BoundField DataField="PhoneNumber" HeaderText="Phone Number" SortExpression="PhoneNumber" />
                            <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                        </Columns>
                    </asp:GridView>
                </div>
                <div class="btnUpdateProfileChangePassword">
                    <asp:Button ID="btnUpdateProfile" runat="server" Text="Update Profile" OnClick="btnUpdateProfile_Click" />
                    <asp:Button ID="btnChangePassword" runat="server" Text="Change Password" OnClick="btnChangePassword_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
