<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AcceptedPaymentTransaction.aspx.cs" Inherits="Telecom_Company_Team_9.AcceptedPaymentTransaction" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Page Heading -->
    <h1 class="page-heading">Accepted Payment Transactions</h1>

    <!-- Input Mobile Number Section -->
    <div class="input-section">
        <asp:Label ID="InputNumberLabel" runat="server" Text="Input Mobile Number:" class="label-text"></asp:Label>
        <asp:TextBox ID="InputNumber" runat="server" CssClass="input-textbox"></asp:TextBox>
    </div>

    <!-- Button Section -->
    <div class="button-section">
        <asp:Button ID="RetrievePaymentsButton" runat="server" Text="Retrieve Data!" 
                    OnClick="RetrievePaymentsButton_Click" CssClass="action-button" />
    </div>

    <!-- GridView Section -->
    <div class="gridview-container">
        <asp:GridView ID="AcceptedPaymentTransactionView" runat="server" CssClass="gridview">
            <FooterStyle CssClass="gridview-footer" />
            <HeaderStyle CssClass="gridview-header" />
            <PagerStyle CssClass="gridview-pager" />
            <RowStyle CssClass="gridview-row" />
        </asp:GridView>
    </div>

    <!-- Message Label -->
    <p>
        <asp:Label ID="Message" runat="server" Text="" class="message-label"></asp:Label>
    </p>
</asp:Content>
