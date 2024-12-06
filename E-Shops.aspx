<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="E-Shops.aspx.cs" Inherits="Telecom_Company_Team_9.E_Shops" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Page Heading -->
    <h1 style="font-family: 'Montserrat', Arial, sans-serif; font-weight: 600;">All E-Shops</h1>

    <!-- GridView container with some padding -->
    <div class="gridview-container">
        <asp:GridView ID="E_ShopsView" runat="server" CssClass="gridview">
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
