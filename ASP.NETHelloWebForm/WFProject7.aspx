<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFProject7.aspx.cs" 
    Inherits="ASPHelloWebForm.WFProject7" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBox1" runat="server" Height="137px" Width="134px">
                <asp:ListItem>Red</asp:ListItem>
                <asp:ListItem>Green</asp:ListItem>
                <asp:ListItem>Blue</asp:ListItem>
            </asp:ListBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Click" />
            <asp:Image ID="Image1" runat="server" Height="200px" 
                Width="200px" />
        </div>
    </form>
</body>
</html>
