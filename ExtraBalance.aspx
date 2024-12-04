<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ExtraBalance.aspx.cs" Inherits="Telecom_Company_Team_9.ExtraBalance" %>



        <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <!--Part 5-->
        <h2>Check Here for the Extra Balance on the account</h2>
        <br />
        Mobile Number:<br />
        <asp:TextBox ID="mobileNumE" runat="server"></asp:TextBox>
        <br />
        Plan name:<br />
        <asp:TextBox ID="plannameE" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="ButtonExtAmount" runat="server" Text="Check" OnClick ="ViewExtraAmount" />
        <br />
        <br />
        <asp:Label ID="LabelExt" runat="server" ></asp:Label>
        <br />
        </asp:Content>
