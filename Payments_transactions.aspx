<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Payments_transactions.aspx.cs" Inherits="Telecom_Company_Team_9.Payments_transactions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>View all payments</h1>
    <asp:GridView ID="Payments_transactionView" runat="server"></asp:GridView>
    <p>
    <asp:Label ID="Message" runat="server" Text=""></asp:Label>
    </p>
</asp:Content>