<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateCookie.aspx.cs" Inherits="P_ClientSide_StateManagement.CreateCookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem Value="Grapes"></asp:ListItem>
            <asp:ListItem Value="Mango"></asp:ListItem>
            <asp:ListItem Value="Orange"></asp:ListItem>
            <asp:ListItem Value="Apple"></asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Go to ReadCookie" />
       
    </form>
</body>
</html>
