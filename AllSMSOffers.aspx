<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AllSMSOffers.aspx.cs" Inherits="Telecom_Company_Team_9.AllSMSOffers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <body>
        <div>
            <asp:Label ID="Label1" Visible="false" runat="server" Text="Label"></asp:Label>
            <br />
            Input Your Mobile Number:
                         <br />
            <asp:TextBox ID="TextBox4" Visible="false" runat="server"></asp:TextBox>
            <asp:Button ID="Button9" Visible="false" runat="server" OnClick="Button9_Click" Text="Search" />
            <br />
            <br />

            <asp:GridView ID="GridView6" runat="server" CellPadding="4" CssClass="gridview">
                <FooterStyle CssClass="gridview-footer" />
                <HeaderStyle CssClass="gridview-header" />
                <PagerStyle CssClass="gridview-pager" />
                <RowStyle CssClass="gridview-row" />
            </asp:GridView>
        </div>
</asp:Content>
