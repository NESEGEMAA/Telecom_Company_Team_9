<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AllServicePlans.aspx.cs" Inherits="Telecom_Company_Team_9.DashBoard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Button ID="AllServices" runat="server" Text="All Service Plans" OnClick ="AllServicePlans" />
        <asp:Label ID="ErrorMessageAllServices" runat="server" ForeColor="Red" Text=""></asp:Label>
        <asp:GridView ID="GridViewAlLServices" runat="server" AutoGenerateColumns="true" HeaderStyle-BackColor="LightGray" BorderWidth="1" />
    </div>
</asp:Content>
