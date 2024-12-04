<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UnsubscribedServices.aspx.cs" Inherits="Telecom_Company_Team_9.UnsubscribedServices" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="UnsubscribedForm" runat="server">
        <div>
            <asp:Label ID="Unsubscribed" runat="server" Text="Mobile no: "></asp:Label>
            <asp:TextBox ID="Mobileno" runat="server"></asp:TextBox>
            <asp:Button ID="EnteredNumber" runat="server" Text="Enter" OnClick ="UnsubscribedTable" />
            <asp:GridView ID="GridViewUnsubscribedPlans" runat="server" AutoGenerateColumns="true"></asp:GridView>
            <asp:Label ID="ErrorMessageUnsubscribtion" runat="server" ForeColor="Red" Text=""></asp:Label>

        </div>
    </form>
</body>
</html>

