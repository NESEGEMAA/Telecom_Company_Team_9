﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="LinkedWallet.aspx.cs" Inherits="Telecom_Company_Team_9.LinkedWallet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Page Heading -->
    <h1>Account Wallet</h1>

    <!-- Input Mobile Number Section -->
    <h2>Input Mobile Number:
    </h2>
    <asp:TextBox ID="InputNumber" runat="server" CssClass="form-control"></asp:TextBox>
    <!-- Button Section -->
    <asp:Button ID="RetrieveValidityButton" runat="server" Text="Retrieve Data"
        OnClick="RetrieveCashbackButton_Click" CssClass="btn-style" />

    <!-- GridView Section -->
    <div class="gridview-container">
        <asp:GridView ID="LinkedWalletView" runat="server" CssClass="gridview">
            <FooterStyle CssClass="gridview-footer" />
            <HeaderStyle CssClass="gridview-header" />
            <PagerStyle CssClass="gridview-pager" />
            <RowStyle CssClass="gridview-row" />
        </asp:GridView>
    </div>

    <!-- Message Label -->
    <asp:Label ID="Message" runat="server" Text="" CssClass="label"></asp:Label>
    <asp:Label ID="Message2" runat="server" Text="" CssClass="label2"></asp:Label>

</asp:Content>

