<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="RemainingBalance.aspx.cs" Inherits="Telecom_Company_Team_9.RemainingBalance" %>


        <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
         <!-- Part 4-->
         <h1> Check Here for Remaining balance on the account </h1>
         <br />
         <h2>Mobile Number:</h2>
         <asp:TextBox ID="mobileNumR" runat="server"></asp:TextBox>
         <br />
         <h2>Plan name:</h2>
         <asp:TextBox ID="plannameR" runat="server"></asp:TextBox>
         <br />
         <br />
         <asp:Button ID="ButtonRemAmount" runat="server" Text="Check" OnClick ="ViewRemainingAmount" CssClass="btn-style"/>
         <br />
         <br />
         <asp:Label ID="LabelRem" runat="server" CssClass="label"></asp:Label>
         <br />
         <br />
     
         <br />
           </asp:Content>
