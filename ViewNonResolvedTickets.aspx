<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ViewNonResolvedTickets.aspx.cs" Inherits="Telecom_Company_Team_9.ViewNonResolvedTickets" %>

        <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <!-- Part 2-->
          <h2>Check for Unresolved Tickets Here </h2>
        <br />
        <p1> Enter National ID:</p1>
    
         <br />
         <asp:TextBox ID="NID" runat="server" Placeholder="Enter National ID"></asp:TextBox>
         <br />
    
        <br />
        <asp:Button ID="ButtonTickets" runat="server" Text="Check" OnClick="ViewTickets" />

        <br />
        <br />
        <asp:Label ID="lblTicketCount" runat="server" ></asp:Label>

        </asp:Content>