<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="LastFiveMonthSubscribedPlans.aspx.cs" Inherits="Telecom_Company_Team_9.LastFiveMonthSubscribedPlans" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>Service plans you subscribed to in the past 5 months:</p>

    <asp:TextBox ID="LastFiveMonthsPlansInputNumber" runat="server" placeholder="Enter your mobile number"></asp:TextBox><br />

    <asp:Button ID="ButtonLastFiveMonthsPlans" runat="server" Text="View past 5 months' plans" OnClick="ViewLastFiveMonthsPlans" />
    <asp:GridView ID="LastFiveMonthsPlans" runat="server" CssClass="gridview">
        <FooterStyle CssClass="gridview-footer" />
        <HeaderStyle CssClass="gridview-header" />
        <PagerStyle CssClass="gridview-pager" />
        <RowStyle CssClass="gridview-row" />
    </asp:GridView>
    <asp:Label ID="LastFiveMonthsPlansErrorMessage" runat="server" Text=""></asp:Label>
</asp:Content>
