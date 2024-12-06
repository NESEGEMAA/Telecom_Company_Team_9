<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="CashbackCalculator.aspx.cs" Inherits="Telecom_Company_Team_9.CashbackCalculator" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Receive your Cashback!</h1>
    <h2>Input your mobile number:</h2>
    <asp:TextBox ID="InputMobileNumber" runat="server" CssClass="form-control"></asp:TextBox>
    <h2>Input the payment ID:</h2>
    <asp:TextBox ID="InputPaymentID" runat="server" CssClass="form-control"></asp:TextBox>
    <h2>Input Benefit ID:</h2>
    <asp:TextBox ID="InputBenefitID" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <asp:Label ID="Message" runat="server" Text="" CssClass="label"></asp:Label>
    <br />
    <asp:Button ID="Calculatebutton" runat="server" Text="Calculate!" OnClick="Calculate" CssClass="btn-style"/>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="FooterContent" Runat="Server">
    <p style="color: red">The number displayed in the text box on loading the page is the current logged in customer's number; However, the ability to overwrite it is kept for means of testing</p>
</asp:Content>