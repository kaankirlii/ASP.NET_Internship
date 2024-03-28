<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFProject8.aspx.cs" 
    Inherits="ASPHelloWebForm.WFProject8" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Try-Catch with panel</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" BackColor="RoyalBlue" Height="156px" Width="410px">
                <asp:Label ID="Label1" runat="server" Text="First Number: " 
                    ForeColor="#66FFFF"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" Width="80px"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" Text="Second Number: " 
                    ForeColor="#66FFFF"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" Width="80px"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Calculate" 
                    BackColor="#FF3300" BorderStyle="Solid" 
                    Font-Bold="True" ForeColor="Black" OnClick="Button1_Click" />
                <br />
                <asp:Label ID="Label3" runat="server" ForeColor="#66FFFF"></asp:Label>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
