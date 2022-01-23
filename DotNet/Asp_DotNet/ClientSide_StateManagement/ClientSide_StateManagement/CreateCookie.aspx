<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateCookie.aspx.cs" Inherits="ClientSide_StateManagement.CreateCookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem Value="35000">HP</asp:ListItem>
                <asp:ListItem Value="ASUS"></asp:ListItem>
                <asp:ListItem Value="Canon"></asp:ListItem>
                <asp:ListItem Value="Epson"></asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Go to ReadCookie" />
        </div>
    </form>
</body>
</html>
