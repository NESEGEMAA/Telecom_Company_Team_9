<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="UnsubscribedServices.aspx.cs" Inherits="Telecom_Company_Team_9.UnsubscribedServices" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Our other plans</h1>
    <h2>Mobile no:</h2>
    <asp:TextBox ID="Mobileno" runat="server"></asp:TextBox>
    <asp:Button ID="EnteredNumber" runat="server" Text="Enter" OnClick ="UnsubscribedTable" CssClass="btn-style"/>
    <asp:GridView ID="GridViewUnsubscribedPlans" runat="server" AutoGenerateColumns="true" CssClass="gridview">
        <FooterStyle CssClass="gridview-footer" />
        <HeaderStyle CssClass="gridview-header" />
        <PagerStyle CssClass="gridview-pager" />
        <RowStyle CssClass="gridview-row" />
    </asp:GridView>
    <asp:Label ID="ErrorMessageUnsubscribtion" runat="server" Text="" CssClass="label"></asp:Label>
</asp:Content>