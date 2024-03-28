<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFProject3.aspx.cs" 
    Inherits="ASPHelloWebForm.WFProject3" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Nth Fibonacci Value</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Please enter upper limit fibonacci number: ">
            </asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Width="60px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calculate" />
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Result: "></asp:Label>
            <asp:Label ID="Label3" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
