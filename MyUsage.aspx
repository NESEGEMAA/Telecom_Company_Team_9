<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyUsage.aspx.cs" Inherits="Telecom_Company_Team_9.MyUsage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MyUsageForm" runat="server">
        <div>
            <asp:Label ID="MyUsage" runat="server" Text="Mobile no: "></asp:Label>
            <asp:TextBox ID="Mobileno" runat="server"></asp:TextBox>
            <asp:Button ID="EnteredNumber" runat="server" Text="Enter" OnClick ="MyUsageTable" />
            <asp:GridView ID="GridViewMyUsage" runat="server" AutoGenerateColumns="true"></asp:GridView>
            <asp:Label ID="ErrorMessageMyUsage" runat="server" ForeColor="Red" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>

