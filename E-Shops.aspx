<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="E-Shops.aspx.cs" Inherits="Telecom_Company_Team_9.E_Shops" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>View all E-Shops</h1>
    <asp:GridView ID="E_ShopsView" runat="server">
    </asp:GridView>
        <p>
            <asp:Label ID="Message" runat="server" Text=""></asp:Label>
        </p>
</asp:Content>