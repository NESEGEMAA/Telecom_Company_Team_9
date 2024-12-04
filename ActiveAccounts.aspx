<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ActiveAccounts.aspx.cs" Inherits="Telecom_Company_Team_9.ActiveAccounts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                       <asp:Button ID="Button1" runat="server" OnClick="Show_Accounts" Text="All Active Accounts" />
 
             <asp:GridView ID="GridView1" runat="server" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" Visible ="False" DataKeyNames="nationalID,mobileNo">
     <AlternatingRowStyle BackColor="White" />
     <Columns>
         <asp:BoundField DataField="nationalID" HeaderText="nationalID" ReadOnly="True" SortExpression="nationalID" />
         <asp:BoundField DataField="first_name" HeaderText="first_name" SortExpression="first_name" />
         <asp:BoundField DataField="last_name" HeaderText="last_name" SortExpression="last_name" />
         <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
         <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
         <asp:BoundField DataField="date_of_birth" HeaderText="date_of_birth" SortExpression="date_of_birth" />
         <asp:BoundField DataField="mobileNo" HeaderText="mobileNo" ReadOnly="True" SortExpression="mobileNo" />
         <asp:BoundField DataField="account_type" HeaderText="account_type" SortExpression="account_type" />
         <asp:BoundField DataField="status" HeaderText="status" SortExpression="status" />
         <asp:BoundField DataField="start_date" HeaderText="start_date" SortExpression="start_date" />
         <asp:BoundField DataField="balance" HeaderText="balance" SortExpression="balance" />
         <asp:BoundField DataField="points" HeaderText="points" SortExpression="points" />
     </Columns>
     <EditRowStyle BackColor="#2461BF" />
     <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
     <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
     <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
     <RowStyle BackColor="#EFF3FB" />
     <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
     <SortedAscendingCellStyle BackColor="#F5F7FB" />
     <SortedAscendingHeaderStyle BackColor="#6D95E1" />
     <SortedDescendingCellStyle BackColor="#E9EBEF" />
     <SortedDescendingHeaderStyle BackColor="#4870BE" />
 </asp:GridView>
 
           <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Milestone2SolConnectionString %>" SelectCommand="SELECT * FROM [allCustomerAccounts]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
