<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Payments_transactions.aspx.cs" Inherits="Telecom_Company_Team_9.Payments_transactions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Page Heading -->
    <h1 style="font-family: 'Montserrat', Arial, sans-serif; font-weight: 600;">All Payments</h1>

    <!-- GridView container with borders -->
    <div class="gridview-wrapper">
        <asp:GridView ID="Payments_transactionView" runat="server" CssClass="gridview">
            <FooterStyle CssClass="gridview-footer" />
            <HeaderStyle CssClass="gridview-header" />
            <PagerStyle CssClass="gridview-pager" />
            <RowStyle CssClass="gridview-row" />
            <AlternatingRowStyle BackColor="#f2f2f2" />
        </asp:GridView>
    </div>

    <!-- Message Display -->
    <p>
        <asp:Label ID="Message" runat="server" Text="" CssClass="label"></asp:Label>
    </p>
</asp:Content>
