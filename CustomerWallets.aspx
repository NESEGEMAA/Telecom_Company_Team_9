﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="CustomerWallets.aspx.cs" Inherits="Telecom_Company_Team_9.CustomerWallets" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>View All Customer Wallets</h1>
    <asp:GridView ID="CustomerWalletView" runat="server"></asp:GridView>
    <p>
        <asp:Label ID="Message" runat="server" Text=""></asp:Label>
    </p>
</asp:Content>