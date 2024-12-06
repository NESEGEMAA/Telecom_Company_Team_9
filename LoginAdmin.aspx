<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginAdmin.aspx.cs" Inherits="Telecom_Company_Team_9.Login" MasterPageFile="~/Site.master" %>

<asp:Content runat="server" ID="Content2" ContentPlaceHolderID="HeadContent">
    <!-- Page-specific CSS -->
    <link href="/Content/Login.css?v=1.0" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Admin Login</h1>
    <h3>Mobile number: </h3>
    <asp:TextBox ID="mobile" runat="server" CssClass="form-control"></asp:TextBox>

    <h3>Password: 
    </h3>
    <asp:TextBox ID="password" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
    <asp:Button ID="login_button" runat="server" OnClick="login" Text="Login" CssClass="btn-style" />
    <br />
    <br />
    <asp:Label ID="ErrorMessage" runat="server" CssClass="label" />
</asp:Content>
