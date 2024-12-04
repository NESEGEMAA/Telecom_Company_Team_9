<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginCustomer.aspx.cs" Inherits="Telecom_Company_Team_9.LoginCustomer" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="signin" runat="server">
        <div>
            Login page 
            <br />
            <br />
            <asp:Label ID="M1" runat="server" Text="Mobile number: "></asp:Label>
            <asp:TextBox ID="MobileNumber" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="P1" runat="server" Text="Password: "></asp:Label>
            <asp:TextBox ID="Password" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="ButtonL" runat="server" Text="Login" OnClick="Login" />
            <asp:Label ID="ErrorMessage" runat="server" ForeColor="Red" Text="" />
        </div>
    </form>
</body>
</html>

