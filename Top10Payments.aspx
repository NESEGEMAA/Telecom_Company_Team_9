<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Top10Payments.aspx.cs" Inherits="Telecom_Company_Team_9.Top10Payments" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Part 6-->
    <h1>Check Top 10 Successful Payments on the account</h1>
    <br />
    <h2>Mobile Number:</h2>
    <asp:TextBox ID="mob" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <br />
        
    <asp:Button ID="ButtonPayment" runat="server" Text="View Payments" OnClick="PaymentView" CssClass="btn-style"/>
    <asp:GridView ID="GridViewPayment" runat="server" CssClass="gridview">
        <FooterStyle CssClass="gridview-footer" />
        <HeaderStyle CssClass="gridview-header" />
        <PagerStyle CssClass="gridview-pager" />
        <RowStyle CssClass="gridview-row" />
    </asp:GridView>
    <br />
    <asp:Label ID="LabelPayment" runat="server" CssClass="label"></asp:Label>
    <asp:Label ID="LabelPayment2" runat="server" CssClass="label2"></asp:Label>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="FooterContent" Runat="Server">
    <p style="color: red">The number displayed in the text box on loading the page is the current logged in customer's number; However, the ability to overwrite it is kept for means of testing</p>
</asp:Content>