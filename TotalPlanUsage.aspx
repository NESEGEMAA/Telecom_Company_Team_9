<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TotalPlanUsage.aspx.cs" Inherits="Telecom_Company_Team_9.TotalUsage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            Input a date:
            <asp:Calendar ID="Calendar2" Visible="false" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px" SelectedDate="2024-12-01">
    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
    <NextPrevStyle VerticalAlign="Bottom" />
    <OtherMonthDayStyle ForeColor="#808080" />
    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
    <SelectorStyle BackColor="#CCCCCC" />
    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
    <WeekendDayStyle BackColor="#FFFFCC" />
</asp:Calendar>
            Input your Mobile Number:
            <br />
          <asp:TextBox ID="TextBox5" Visible="false" runat="server"></asp:TextBox>
                        <asp:Button ID="Button10" Visible ="false" runat="server" Text="Search" OnClick="Button10_Click" />
            <br /><br />
            <asp:GridView ID="GridView7" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
    <AlternatingRowStyle BackColor="White" />
    <EditRowStyle BackColor="#7C6F57" />
    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#E3EAEB" />
    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#F8FAFA" />
    <SortedAscendingHeaderStyle BackColor="#246B61" />
    <SortedDescendingCellStyle BackColor="#D4DFE1" />
    <SortedDescendingHeaderStyle BackColor="#15524A" />
</asp:GridView>
        </div>
    </form>
</body>
</html>
