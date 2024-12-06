<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginCustomer.aspx.cs" Inherits="Telecom_Company_Team_9.LoginCustomer" MasterPageFile="~/Site.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <link href="/Content/Login.css?v=1.0" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="login-container">
        <h1>Customer Login</h1>

        <div class="form-group">
            <asp:Label ID="M1" runat="server" Text="Mobile number: " class="form-group label"></asp:Label>
            <asp:TextBox ID="MobileNumber" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Label ID="P1" runat="server" Text="Password: " class="form-group label"></asp:Label>
            <asp:TextBox ID="Password" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Button ID="ButtonL" runat="server" Text="Login" CssClass="btn-style" OnClick="Login" />
        </div>

        <asp:Label ID="ErrorMessage" runat="server" CssClass="label" />
    </div>
</asp:Content>
