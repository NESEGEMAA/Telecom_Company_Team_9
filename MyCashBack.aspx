<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyCashBack.aspx.cs" Inherits="Telecom_Company_Team_9.MyCashBack" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="CashBackForm" runat="server">
        <div>
            <asp:Label ID="MyCashback" runat="server" Text="National ID: "></asp:Label>
            <asp:TextBox ID="NID" runat="server"></asp:TextBox>
            <asp:Button ID="EnteredID" runat="server" Text="Enter" OnClick ="MyCashBackTable" />
            <asp:GridView ID="GridViewMyCashBack" runat="server" AutoGenerateColumns="true"></asp:GridView>
            <asp:Label ID="ErrorMessageMyCashBack" runat="server" ForeColor="Red" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>

