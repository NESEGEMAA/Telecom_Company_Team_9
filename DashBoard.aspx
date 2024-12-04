<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DashBoard.aspx.cs" Inherits="Telecom_Company_Team_9.DashBoard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="dashb" runat="server">
        <div>
            <asp:Button ID="AllServices" runat="server" Text="All Service Plans" OnClick ="AllServicePlans" />
            <asp:Label ID="ErrorMessageAllServices" runat="server" ForeColor="Red" Text=""></asp:Label>
            <asp:GridView ID="GridViewAlLServices" runat="server" AutoGenerateColumns="true" HeaderStyle-BackColor="LightGray" BorderWidth="1" />
            <asp:Button ID="Consume" runat="server" Text="My Consumption" OnClick ="MyConsumption" />
            <asp:Label ID="ConsumeErrorMessage" runat="server" ForeColor="Red" Text=""></asp:Label>
            <asp:Button ID="Unsubscribed" runat="server" Text="Unsubscribed Services" OnClick ="UnsubscribedServices"/>
            <asp:Label ID="UnsubscribedErrorMessage" runat="server" ForeColor="Red" Text=""></asp:Label>
            <asp:Button ID="Usage" runat="server" Text="My Usage" OnClick="MyUsageButton" />
            <asp:Label ID="MyUsageErrorMessage" runat="server" ForeColor="Red" Text=""></asp:Label>
            <asp:Button ID="Cashback" runat="server" Text="My Cashback Transactions" OnClick="MyCashbackTransactions" />
            <asp:Label ID="CashbackErrorMessage" runat="server" ForeColor="Red" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
