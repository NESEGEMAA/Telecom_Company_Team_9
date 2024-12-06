<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="TotalPlanUsage.aspx.cs" Inherits="Telecom_Company_Team_9.TotalUsage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1>
            Input Account Total Plan Usage
        </h1>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
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
        <br />
        Input your Mobile Number:
            <br />
        <asp:TextBox ID="TextBox5" Visible="false" runat="server"></asp:TextBox>
        <asp:Button ID="Button10" Visible="false" runat="server" Text="Search" OnClick="Button10_Click" />
        <br />
        <br />
        <asp:GridView ID="GridView7" runat="server" CssClass="gridview">
            <FooterStyle CssClass="gridview-footer" />
            <HeaderStyle CssClass="gridview-header" />
            <PagerStyle CssClass="gridview-pager" />
            <RowStyle CssClass="gridview-row" />
        </asp:GridView>
    </div>
</asp:Content>
