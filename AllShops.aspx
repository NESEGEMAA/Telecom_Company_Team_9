<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AllShops.aspx.cs" Inherits="Telecom_Company_Team_9.AllShops" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>All shop details</h1>

    <asp:GridView ID="AllShopsGridView" runat="server" CellPadding="4" CssClass="gridview">
        <FooterStyle CssClass="gridview-footer" />
        <HeaderStyle CssClass="gridview-header" />
        <PagerStyle CssClass="gridview-pager" />
        <RowStyle CssClass="gridview-row" />
    </asp:GridView>
    <asp:Label ID="AllShopsErrorMessage" runat="server" Text="" CssClass="label2"></asp:Label>
</asp:Content>