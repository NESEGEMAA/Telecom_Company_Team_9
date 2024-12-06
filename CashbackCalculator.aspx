<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="CashbackCalculator.aspx.cs" Inherits="Telecom_Company_Team_9.CashbackCalculator" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Receive your Cashback!</h1>
    <h2>Input your mobile number:</h2>
    <asp:TextBox ID="InputMobileNumber" runat="server"></asp:TextBox>
    <h2>Input the payment ID:</h2>
    <asp:TextBox ID="InputPaymentID" runat="server"></asp:TextBox>
    <h2>Input Benefit ID:</h2>
    <asp:TextBox ID="InputBenefitID" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Message" runat="server" Text="" CssClass="label"></asp:Label>
    <br />
    <asp:Button ID="Calculatebutton" runat="server" Text="Calculate!" OnClick="Calculate" CssClass="btn-style"/>
</asp:Content>
