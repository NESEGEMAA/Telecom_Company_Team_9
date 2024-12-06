<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AcceptedPaymentTransaction.aspx.cs" Inherits="Telecom_Company_Team_9.AcceptedPaymentTransaction" %>

<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Page Heading -->
    <h1>Accepted Payment Transactions</h1>

    <!-- Input Mobile Number Section -->
        <h2>
            Input Mobile Number:
        </h2>
        <asp:TextBox ID="InputNumber" runat="server" CssClass="form-control"></asp:TextBox>

    <!-- Button Section -->
        <asp:Button ID="RetrievePaymentsButton" runat="server" Text="Retrieve Data!" 
                    OnClick="RetrievePaymentsButton_Click" CssClass="btn-style" />
    <br />
    <br />
    <asp:Label ID="PaymentsNumLabel" runat="server" CssClass="label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="SumOfPointsLabel" runat="server" Text="" CssClass="label"></asp:Label>
    <br />
    <!-- Message Label -->
        <asp:Label ID="Message" runat="server" Text="" CssStyle="label"></asp:Label>
</asp:Content>
