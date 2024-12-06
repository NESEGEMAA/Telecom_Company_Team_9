<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="WalletCashbackAmount.aspx.cs" Inherits="Telecom_Company_Team_9.WalletCashbackAmount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Page Heading -->
    <h1>Check Input Cashback Amount</h1>

    <!-- Input Mobile Number Section -->
    <h2>Input WalletID:
    </h2>

    <asp:TextBox ID="InputNumber" runat="server" CssClass="form-control"></asp:TextBox>

    <h2>Input PlanID:
    </h2>

    <asp:TextBox ID="InputNumber2" runat="server" CssClass="form-control"></asp:TextBox>

    <!-- Button Section -->
    <asp:Button ID="RetrieveAverageTransactionsAmountButton" runat="server" Text="Retrieve Data"
        OnClick="RetrieveAverageTransactionsAmountButton_Click" CssClass="btn-style" />

    <!-- GridView Section -->
    <div class="gridview-container">
        <asp:GridView ID="AverageTransactionsAmountsView" runat="server" CssClass="gridview">
            <FooterStyle CssClass="gridview-footer" />
            <HeaderStyle CssClass="gridview-header" />
            <PagerStyle CssClass="gridview-pager" />
            <RowStyle CssClass="gridview-row" />
        </asp:GridView>
    </div>

    <!-- Message Label -->
    <p>
        <asp:Label ID="Message" runat="server" Text="" CssClass="label" class="message-label"></asp:Label>
    </p>
</asp:Content>
