<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="RechargeBalance.aspx.cs" Inherits="Telecom_Company_Team_9.RechargeBalance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Recharge your balance here:</h1>
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
        <asp:Label ID="Message" runat="server" Text=""></asp:Label>
    </section>
    <asp:Button ID="rechargeButton" runat="server" Text="Recharge!" OnClick="Recharge" />
</asp:Content>