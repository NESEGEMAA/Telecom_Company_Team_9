<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="MyConsumption.aspx.cs" Inherits="Telecom_Company_Team_9.MyConsumption" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>View Everyone's plan consumption for some reason</h1>
    <asp:Label ID="Plan" runat="server" Text="Select the plan name here: "></asp:Label> 
    <asp:DropDownList ID="PlanList" runat="server">
        <asp:ListItem Text="Basic" Value="Basic"></asp:ListItem>
        <asp:ListItem Text="Premium" Value="Premium"></asp:ListItem>
        <asp:ListItem Text="Ultimate" Value="Ultimate"></asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Label ID="Startdate" runat="server" Text="Choose the start date"></asp:Label>
    <br />
    <div class="calendar-container">
        <asp:Calendar ID="Calendar1" runat="server" CssClass="calendar-table" />
    </div>
    <br />
    <br />
    <asp:Label ID="Enddate" runat="server" Text="Choose the end date"></asp:Label>
    <br />
    <div class="calendar-container">
        <asp:Calendar ID="Calendar2" runat="server" CssClass="calendar-table" />
    </div>
    <br />
    <asp:Button ID="ButtonMC" runat="server" Text="Submit" OnClick ="Compute" />
    <asp:GridView ID="GridViewMyConsumption" runat="server" CssClass="gridview">
        <FooterStyle CssClass="gridview-footer" />
        <HeaderStyle CssClass="gridview-header" />
        <PagerStyle CssClass="gridview-pager" />
        <RowStyle CssClass="gridview-row" />
    </asp:GridView>
    <asp:Label ID="ErrorMessageMyConsumption" runat="server" ForeColor="Red" Text=""></asp:Label>
</asp:Content>

