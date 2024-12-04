<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyConsumption.aspx.cs" Inherits="Telecom_Company_Team_9.MyConsumption" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="ConsumptionForm" runat="server">
        <div>
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
        </div>
    </form>
</body>
</html>
