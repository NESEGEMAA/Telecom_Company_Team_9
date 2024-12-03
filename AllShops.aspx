<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AllShops.aspx.cs" Inherits="Telecom_Company_Team_9.AllShops" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>All shop details</p>

    <asp:Button ID="ButtonAllShops" runat="server" Text="View all shops" OnClick="ViewAllShops" />
    <asp:GridView ID="AllShopsGridView" runat="server">
    </asp:GridView>
    <asp:Label ID="AllShopsErrorMessage" runat="server" Text=""></asp:Label>
</asp:Content>