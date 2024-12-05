<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Payments_transactions.aspx.cs" Inherits="Telecom_Company_Team_9.Payments_transactions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Page Heading -->
    <h1 style="font-family: 'Montserrat', Arial, sans-serif; font-weight: 600;">View All Payments</h1>

    <!-- GridView container with borders -->
    <div class="gridview-container">
        <asp:GridView ID="Payments_transactionView" runat="server" CssClass="gridview-with-borders">
            <FooterStyle CssClass="gridview-footer" />
            <HeaderStyle CssClass="gridview-header" />
            <PagerStyle CssClass="gridview-pager" />
            <RowStyle CssClass="gridview-row" />
        </asp:GridView>
    </div>

    <!-- Message Display -->
    <p>
        <asp:Label ID="Message" runat="server" Text="" CssClass="message-label"></asp:Label>
    </p>
</asp:Content>
