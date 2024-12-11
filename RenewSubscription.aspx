<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="RenewSubscription.aspx.cs" Inherits="Telecom_Company_Team_9.RenewSubscription" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Renew your subscription here:</h1>
    <h2>Input your Mobile Number</h2>
    <asp:TextBox ID="InputMobileNumber" runat="server" CssClass="form-control"></asp:TextBox>
    <h2>Input the amount you want to recharge with</h2>
    <asp:TextBox ID="InputAmount" runat="server" CssClass="form-control"></asp:TextBox>
    <h2>Choose the payment method</h2>
    <section>
        <asp:DropDownList ID="paymentMethodDropDownList" CssClass="form-control" runat="server">
            <asp:ListItem>cash</asp:ListItem>
            <asp:ListItem>credit</asp:ListItem>
        </asp:DropDownList>
    </section>
    <h2>Input the plan ID you would like to renew</h2>
    <asp:TextBox ID="InputPlanId" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <asp:Label ID="Message" runat="server" Text="" CssClass="label"></asp:Label>
    <asp:Label ID="Message2" runat="server" Text="" CssClass="label2"></asp:Label>
    <asp:Button ID="renewButton" runat="server" Text="Renew" OnClick="Renew" CssClass="btn-style"/>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="FooterContent" runat="Server">
    <p style="color: red">The number displayed in the text box on loading the page is the current logged in customer's number; However, the ability to overwrite it is kept for means of testing</p>
</asp:Content>
