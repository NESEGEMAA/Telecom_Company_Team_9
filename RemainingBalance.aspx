<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="RemainingBalance.aspx.cs" Inherits="Telecom_Company_Team_9.RemainingBalance" %>


        <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
         <!-- Part 4-->
         <h2> Check Here for Remaining balance on the account </h2>
         <br />
         <br />
         Mobile Number:<br />
         <asp:TextBox ID="mobileNumR" runat="server"></asp:TextBox>
         <br />
         Plan name:<br />
         <asp:TextBox ID="plannameR" runat="server"></asp:TextBox>
         <br />
         <br />
         <asp:Button ID="ButtonRemAmount" runat="server" Text="Check" OnClick ="ViewRemainingAmount" />
         <br />
         <br />
         <asp:Label ID="LabelRem" runat="server" ></asp:Label>
         <br />
         <br />
     
         <br />
           </asp:Content>
