<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="MyCashBack.aspx.cs" Inherits="Telecom_Company_Team_9.MyCashBack" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label ID="MyCashback" runat="server" Text="National ID: "></asp:Label>
        <asp:TextBox ID="NID" runat="server"></asp:TextBox>
        <asp:Button ID="EnteredID" runat="server" Text="Enter" OnClick ="MyCashBackTable" />
        <asp:GridView ID="GridViewMyCashBack" runat="server" AutoGenerateColumns="true"></asp:GridView>
        <asp:Label ID="ErrorMessageMyCashBack" runat="server" ForeColor="Red" Text=""></asp:Label>
    </div>
</asp:Content>

