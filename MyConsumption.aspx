<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="MyConsumption.aspx.cs" Inherits="Telecom_Company_Team_9.MyConsumption" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Plan" runat="server" Text="Select the plan name here: "></asp:Label> 
    <asp:DropDownList ID="PlanList" runat="server">
        <asp:ListItem Text="Basic" Value="Basic"></asp:ListItem>
        <asp:ListItem Text="Premium" Value="Premium"></asp:ListItem>
        <asp:ListItem Text="Ultimate" Value="Ultimate"></asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Label ID="Startdate" runat="server" Text="Choose the start date"></asp:Label>
    <br />
    <asp:Calendar ID="Start" runat="server"></asp:Calendar>
    <br />
    <br />
    <asp:Label ID="Enddate" runat="server" Text="Choose the end date"></asp:Label>
    <br />
    <asp:Calendar ID="End" runat="server"></asp:Calendar>
    <br />
    <asp:Button ID="ButtonMC" runat="server" Text="Submit" OnClick ="Compute" />
    <asp:GridView ID="GridViewMyConsumption" runat="server" AutoGenerateColumns="true" HeaderStyle-BackColor="LightGray" BorderWidth="1" />
    <asp:Label ID="ErrorMessageMyConsumption" runat="server" ForeColor="Red" Text=""></asp:Label>
</asp:Content>

