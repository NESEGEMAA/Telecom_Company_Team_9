<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginCustomer.aspx.cs" Inherits="Telecom_Company_Team_9.LoginCustomer" MasterPageFile="~/Site.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
    <link href="/Content/Login.css?v=1.0" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <h1>Customer Login</h1>

    <h3>Mobile number:

    </h3>
    <asp:TextBox ID="MobileNumber" runat="server" CssClass="form-control"></asp:TextBox>

    <h3>Password: 
    </h3>

    <asp:TextBox ID="Password" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
    <br />

    <asp:Button ID="ButtonL" runat="server" Text="Login" CssClass="btn-style" OnClick="Login" />
    <br />
    <br />
    <asp:Label ID="ErrorMessage" runat="server" CssClass="label" />
</asp:Content>
