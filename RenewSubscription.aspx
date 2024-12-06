<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="RenewSubscription.aspx.cs" Inherits="Telecom_Company_Team_9.RenewSubscription" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Renew your subscription here:</h1>
    <h2>Input your Mobile Number</h2>
    <asp:TextBox ID="InputMobileNumber" runat="server"></asp:TextBox>
    <h2>Input the amount you want to recharge with</h2>
    <asp:TextBox ID="InputAmount" runat="server"></asp:TextBox>
    <h2>Choose the payment method</h2>
    <section>
        <asp:DropDownList ID="paymentMethodDropDownList" runat="server">
        <asp:ListItem>cash</asp:ListItem>
        <asp:ListItem>credit</asp:ListItem>
        </asp:DropDownList>
    </section>
    <h2>Input the plan ID you would like to renew</h2>
    <asp:TextBox ID="InputPlanId" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Message" runat="server" Text="" CssClass="label"></asp:Label>
    <asp:Button ID="renewButton" runat="server" Text="Renew" OnClick="Renew" CssClass="btn-style"/>
</asp:Content>
