<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admincomponent2.aspx.cs" Inherits="Telecom_Company_Team_9.admincomponent2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Milestone2SolConnectionString %>" SelectCommand="SELECT * FROM [allCustomerAccounts]"></asp:SqlDataSource>
     
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
