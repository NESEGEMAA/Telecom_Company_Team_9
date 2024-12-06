<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AverageSentTransactionsAmounts.aspx.cs" Inherits="Telecom_Company_Team_9.AverageSentTransactionsAmounts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Page Heading -->
    <h1>Average Transaction Amounts</h1>

    <!-- Input Mobile Number Section -->
    <h2>Input WalletID:
    </h2>
    <asp:TextBox ID="InputWallet" runat="server" CssClass="form-control"></asp:TextBox>

    <h2>Choose the start date
    </h2>
    <div class="calendar-container">
        <asp:Calendar ID="Calendar1" runat="server" CssClass="calendar-table" />
    </div>
    <h2>Choose the end date
    </h2>
    <div class="calendar-container">
        <asp:Calendar ID="Calendar2" runat="server" CssClass="calendar-table" />
    </div>
    <br />
    <!-- Button Section -->
    <asp:Button ID="RetrievePaymentsButton" runat="server" Text="Retrieve Data!"
        OnClick="RetrievePaymentsButton_Click" CssClass="btn-style" />
    <!-- GridView Section -->
    <div class="gridview-container">
        <asp:GridView ID="AverageTransactionAmountView" runat="server" CssClass="gridview">
            <FooterStyle CssClass="gridview-footer" />
            <HeaderStyle CssClass="gridview-header" />
            <PagerStyle CssClass="gridview-pager" />
            <RowStyle CssClass="gridview-row" />
        </asp:GridView>
    </div>

    <!-- Message Label -->
    <asp:Label ID="Message" runat="server" Text="" CssClass="label"></asp:Label>

    <div>
    </div>
</asp:Content>
