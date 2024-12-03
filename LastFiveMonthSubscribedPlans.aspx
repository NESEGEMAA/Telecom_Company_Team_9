<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LastFiveMonthSubscribedPlans.aspx.cs" Inherits="Telecom_Company_Team_9.LastFiveMonthSubscribedPlans" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>Service plans you subscribed to in the past 5 months:</p>

        <asp:TextBox ID="LastFiveMonthsPlansInputNumber" runat="server" placeholder="Enter your mobile number"></asp:TextBox><br />

        <asp:Button ID="ButtonLastFiveMonthsPlans" runat="server" Text="View past 5 months' plans" OnClick="ViewLastFiveMonthsPlans" />
        <asp:GridView ID="LastFiveMonthsPlans" runat="server">
        </asp:GridView>
        <asp:Label ID="LastFiveMonthsPlansErrorMessage" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
