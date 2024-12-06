<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ViewNonResolvedTickets.aspx.cs" Inherits="Telecom_Company_Team_9.ViewNonResolvedTickets" %>

        <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <!-- Part 2-->
        <h1>Check for Unresolved Tickets Here </h1>
        <br />
        <h2> Enter National ID:</h2>
        <br />
        <asp:TextBox ID="NID" runat="server" Placeholder="Enter National ID" CssClass="form-control"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="ButtonTickets" runat="server" Text="Check" OnClick="ViewTickets" CssClass="btn-style"/>

        <br />
        <br />
        <asp:Label ID="lblTicketCount" runat="server" CssClass="label"></asp:Label>

        </asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="FooterContent" Runat="Server">
    <p style="color: red">The output displayed on loading the page is the output for the current logged in customer; However, the ability to fetch other's data is kept for means of testing</p>
</asp:Content>
