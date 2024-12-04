<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SubscribedServicePlans.aspx.cs" Inherits="Telecom_Company_Team_9.SubscribedServicePlans" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button4" runat="server" OnClick="Show_Plans" Text="Show Subscribed Plans" />
            <asp:GridView ID="GridView4" Visible="False" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource4" ForeColor="#333333" GridLines="None">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:BoundField DataField="mobileNo" HeaderText="mobileNo" SortExpression="mobileNo" />
        <asp:BoundField DataField="pass" HeaderText="pass" SortExpression="pass" />
        <asp:BoundField DataField="balance" HeaderText="balance" SortExpression="balance" />
        <asp:BoundField DataField="account_type" HeaderText="account_type" SortExpression="account_type" />
        <asp:BoundField DataField="start_date" HeaderText="start_date" SortExpression="start_date" />
        <asp:BoundField DataField="status" HeaderText="status" SortExpression="status" />
        <asp:BoundField DataField="points" HeaderText="points" SortExpression="points" />
        <asp:BoundField DataField="nationalID" HeaderText="nationalID" SortExpression="nationalID" />
        <asp:BoundField DataField="planID" HeaderText="planID" InsertVisible="False" ReadOnly="True" SortExpression="planID" />
        <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
        <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
        <asp:BoundField DataField="SMS_offered" HeaderText="SMS_offered" SortExpression="SMS_offered" />
        <asp:BoundField DataField="minutes_offered" HeaderText="minutes_offered" SortExpression="minutes_offered" />
        <asp:BoundField DataField="data_offered" HeaderText="data_offered" SortExpression="data_offered" />
        <asp:BoundField DataField="description" HeaderText="description" SortExpression="description" />
    </Columns>
    <EditRowStyle BackColor="#7C6F57" />
    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#E3EAEB" />
    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#F8FAFA" />
    <SortedAscendingHeaderStyle BackColor="#246B61" />
    <SortedDescendingCellStyle BackColor="#D4DFE1" />
    <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
     <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:Milestone2SolConnectionString %>" SelectCommand="Account_Plan" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
