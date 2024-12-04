<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="UnsubscribedServices.aspx.cs" Inherits="Telecom_Company_Team_9.UnsubscribedServices" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label ID="Unsubscribed" runat="server" Text="Mobile no: "></asp:Label>
        <asp:TextBox ID="Mobileno" runat="server"></asp:TextBox>
        <asp:Button ID="EnteredNumber" runat="server" Text="Enter" OnClick ="UnsubscribedTable" />
        <asp:GridView ID="GridViewUnsubscribedPlans" runat="server" AutoGenerateColumns="true"></asp:GridView>
        <asp:Label ID="ErrorMessageUnsubscribtion" runat="server" ForeColor="Red" Text=""></asp:Label>
    </div>
</asp:Content>