<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="UnsubscribedServices.aspx.cs" Inherits="Telecom_Company_Team_9.UnsubscribedServices" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Our other plans</h1>
    <h2>Mobile no:</h2>
    <asp:TextBox ID="Mobileno" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:Button ID="EnteredNumber" runat="server" Text="Enter" OnClick ="UnsubscribedTable" CssClass="btn-style"/>
    <asp:GridView ID="GridViewUnsubscribedPlans" runat="server" AutoGenerateColumns="true" CssClass="gridview">
        <FooterStyle CssClass="gridview-footer" />
        <HeaderStyle CssClass="gridview-header" />
        <PagerStyle CssClass="gridview-pager" />
        <RowStyle CssClass="gridview-row" />
    </asp:GridView>
    <asp:Label ID="ErrorMessageUnsubscribtion" runat="server" Text="" CssClass="label"></asp:Label>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="FooterContent" Runat="Server">
    <p style="color: red">The output displayed on loading the page is the output for the current logged in customer; However, the ability to fetch other's data is kept for means of testing</p>
</asp:Content>