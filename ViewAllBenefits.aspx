<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ViewAllBenefits.aspx.cs" Inherits="Telecom_Company_Team_9.ViewAllBenefits" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

            

    <!-- Part 1-->
    <h2>View all Active Benefits</h2>
    <br />
    <br />
     <asp:GridView ID="GridBenefitView" runat="server" CssClass="gridview">
        <FooterStyle CssClass="gridview-footer" />
        <HeaderStyle CssClass="gridview-header" />
        <PagerStyle CssClass="gridview-pager" />
        <RowStyle CssClass="gridview-row" />
    </asp:GridView>

   
    <br />
    <br />
    <asp:Label ID="BenefitErrorMessage" runat="server"></asp:Label>
    <br />
     
        
        </asp:Content>

