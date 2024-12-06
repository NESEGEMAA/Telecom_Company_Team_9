<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AllSMSOffers.aspx.cs" Inherits="Telecom_Company_Team_9.AllSMSOffers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>All Input SMS Offers
    </h1>
    <body>
        <div>
            <h2>Input Your Mobile Number:
            </h2>
            <asp:TextBox ID="TextBox4" Visible="false" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:Button ID="Button9" Visible="false" runat="server" OnClick="Button9_Click" Text="Search" CssClass="btn-style" />
            <br />
            <br />
            <asp:GridView ID="GridView6" runat="server" CellPadding="4" CssClass="gridview">
                <FooterStyle CssClass="gridview-footer" />
                <HeaderStyle CssClass="gridview-header" />
                <PagerStyle CssClass="gridview-pager" />
                <RowStyle CssClass="gridview-row" />
            </asp:GridView>

            <asp:Label ID="Label1" Visible="false" runat="server" CssClass="message-label" Text="Label"></asp:Label>
        </div>
</asp:Content>
