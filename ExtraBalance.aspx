<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ExtraBalance.aspx.cs" Inherits="Telecom_Company_Team_9.ExtraBalance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!--Part 5-->
    <h1>Check Here for the Extra Balance on the account</h1>
    <br />
    <h2>Mobile Number:</h2>
    <asp:TextBox ID="mobileNumE" runat="server" CssClass="form-control"></asp:TextBox>
    <h2>Plan name:</h2>
    <asp:TextBox ID="plannameE" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="ButtonExtAmount" runat="server" Text="Check" OnClick ="ViewExtraAmount" CssClass="btn-style"/>
    <br />
    <br />
    <asp:Label ID="LabelExt" runat="server" CssClass="label"></asp:Label>
    <br />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="FooterContent" Runat="Server">
    <p style="color: red">The number displayed in the text box on loading the page is the current logged in customer's number; However, the ability to overwrite it is kept for means of testing</p>
</asp:Content>