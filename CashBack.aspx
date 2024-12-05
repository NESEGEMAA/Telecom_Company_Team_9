<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.Master" CodeBehind="CashBack.aspx.cs" Inherits="Telecom_Company_Team_9.CashBack" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Cashback</h1>
    <asp:GridView ID="CashbackView" runat="server">
    </asp:GridView>
        <p>
            <asp:Label ID="Message" runat="server" Text=""></asp:Label>
        </p>
</asp:Content>