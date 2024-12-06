<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="RechargeBalance.aspx.cs" Inherits="Telecom_Company_Team_9.RechargeBalance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Recharge your balance here:</h1>
    <h2>Input your Mobile Number:</h2>
    <asp:TextBox ID="InputMobileNumber" runat="server"></asp:TextBox>
    <h2>Input the amount you want to recharge with:</h2>
    <asp:TextBox ID="InputAmount" runat="server"></asp:TextBox>
    <h2>Choose the payment method</h2>
    <section>
        <asp:DropDownList ID="paymentMethodDropDownList" runat="server">
            <asp:ListItem>cash</asp:ListItem>
            <asp:ListItem>credit</asp:ListItem>
        </asp:DropDownList>
    </section>
    <section>
        <asp:Label ID="Message" runat="server" Text="" CssClass="label"></asp:Label>
    </section>
    <asp:Button ID="rechargeButton" runat="server" Text="Recharge!" OnClick="Recharge" CssClass="btn-style" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="FooterContent" runat="Server">
    <p style="color: red">The number displayed in the text box on loading the page is the current logged in customer's number; However, the ability to overwrite it is kept for means of testing</p>
</asp:Content>
