<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerComponent3.aspx.cs" Inherits="Telecom_Company_Team_9.CustomerComponent3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>All shop details</p>

        <asp:Button ID="ButtonAllShops" runat="server" Text="View all shops" OnClick="AllShopsView" />
        <asp:GridView ID="AllShopsGridView" runat="server">
        </asp:GridView>
        <asp:Label ID="AllShopsErrorMessage" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
