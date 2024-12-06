<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="LastFiveMonthSubscribedPlans.aspx.cs" Inherits="Telecom_Company_Team_9.LastFiveMonthSubscribedPlans" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Service plans you subscribed to in the past 5 months:</h1>

    <asp:TextBox ID="LastFiveMonthsPlansInputNumber" runat="server" placeholder="Enter your mobile number"></asp:TextBox><br />

    <asp:Button ID="ButtonLastFiveMonthsPlans" runat="server" Text="View past 5 months' plans" OnClick="ViewLastFiveMonthsPlans" CssClass="btn-style"/>
    <asp:GridView ID="LastFiveMonthsPlans" runat="server" CssClass="gridview">
        <FooterStyle CssClass="gridview-footer" />
        <HeaderStyle CssClass="gridview-header" />
        <PagerStyle CssClass="gridview-pager" />
        <RowStyle CssClass="gridview-row" />
    </asp:GridView>
    <asp:Label ID="LastFiveMonthsPlansErrorMessage" runat="server" Text="" CssClass="label"></asp:Label>
</asp:Content>
