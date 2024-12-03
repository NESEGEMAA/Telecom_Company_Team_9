<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="RenewSubscription.aspx.cs" Inherits="Telecom_Company_Team_9.RenewSubscription" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Renew your subscription here:</h1>
    <section>
        <asp:Label ID="mobileNumberLabel" runat="server" Text="Input your Mobile Number"></asp:Label>
    </section>
    <section>
        <asp:TextBox ID="InputMobileNumber" runat="server"></asp:TextBox>
    </section>
    <section>
        <asp:Label ID="rechargeAmountLabel" runat="server" Text="Input the amount you want to recharge with"></asp:Label>
    </section>
    <section>
        <asp:TextBox ID="InputAmount" runat="server"></asp:TextBox>
    </section>
        <asp:Label ID="paymentMethodLabel" runat="server" Text="Choose the payment method"></asp:Label>
    <section>
        <asp:DropDownList ID="paymentMethodDropDownList" runat="server">
        <asp:ListItem>cash</asp:ListItem>
        <asp:ListItem>credit</asp:ListItem>
        </asp:DropDownList>
    </section>
    <section>
        <asp:Label ID="planIDLabel" runat="server" Text="Input the plan ID you wanna renew"></asp:Label>
    </section>
    <section>
        <asp:TextBox ID="InputPlanId" runat="server"></asp:TextBox>
    </section>
    <section>
        <asp:Label ID="Message" runat="server" Text=""></asp:Label>
    </section>
    <asp:Button ID="renewButton" runat="server" Text="Renew" OnClick="Renew" />
</asp:Content>
