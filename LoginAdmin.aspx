<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginAdmin.aspx.cs" Inherits="Telecom_Company_Team_9.Login" MasterPageFile="~/Site.master" %>

<asp:Content runat="server" ID="Content2" ContentPlaceHolderID="HeadContent">
    <!-- Page-specific CSS -->
    <link href="/Content/Login.css?v=1.0" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="server">
    <div class="login-container">
        <h1>Admin Login</h1>
        <div class="form-group">
            <label for="mobile">Mobile Num:</label>
            <asp:TextBox ID="mobile" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="password">Password:</label>
            <asp:TextBox ID="password" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Button ID="login_button" runat="server" OnClick="login" Text="Log In" CssClass="btn-login" />
        </div>
        <asp:Label ID="ErrorMessage" runat="server" ForeColor="Red" Text="" />
    </div>
</asp:Content>
