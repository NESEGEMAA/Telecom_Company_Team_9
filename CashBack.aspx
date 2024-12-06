<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="CashBack.aspx.cs" Inherits="Telecom_Company_Team_9.CashBack" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Page Heading -->
    <h1 class="page-heading">All Wallet Cashback Transaction Amounts</h1>

    <!-- GridView container -->
    <div class="gridview-wrapper">
        <asp:GridView ID="CashbackView" runat="server" CssClass="gridview">
            <FooterStyle CssClass="gridview-footer" />
            <HeaderStyle CssClass="gridview-header" />
            <PagerStyle CssClass="gridview-pager" />
            <RowStyle CssClass="gridview-row" />
        </asp:GridView>
    </div>

    <!-- Message Display -->
    <p>
        <asp:Label ID="Message" runat="server" Text="" CssClass="label"></asp:Label>
        <asp:Label ID="Message2" runat="server" Text="" CssClass="label"></asp:Label>
    </p>
</asp:Content>
