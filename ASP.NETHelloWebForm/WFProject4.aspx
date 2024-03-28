<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFProject4.aspx.cs" 
    Inherits="ASPHelloWebForm.WFProject4" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ListBox</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:ListBox ID="ListBox1" runat="server" Height="147px" Width="153px" SelectionMode="Multiple">
            <asp:ListItem>Tomato</asp:ListItem>
            <asp:ListItem>Potato</asp:ListItem>
            <asp:ListItem>Apple</asp:ListItem>
            <asp:ListItem>Orange</asp:ListItem>
            </asp:ListBox>
        &nbsp;
        <asp:Button ID="Button1" runat="server" Text="-->" Width="38px" OnClick="Button1_Click" />&nbsp;
        <asp:ListBox ID="ListBox2" runat="server" Height="147px" Width="153px" SelectionMode="Multiple">
        </asp:ListBox>
        </div>
    </form>
</body>
</html>
