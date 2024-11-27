<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Telecom_Company_Team_9.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
    </title>
</head>
<body>
    <h1>
    LOGIN PAGE
    </h1>
    <form id="form1" runat="server">
        <div>
            Mobile Num:<br />
            <asp:TextBox ID="mobile" runat="server"></asp:TextBox> <br />
            Password:<br />
            <asp:TextBox ID="password" runat="server"></asp:TextBox> <br />
            <asp:Button ID="login_button" runat="server" OnClick="login" Text="Log In" />
        </div>
    </form>
</body>
</html>
