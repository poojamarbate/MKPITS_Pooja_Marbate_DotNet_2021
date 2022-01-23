<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateCookie.aspx.cs" Inherits="MobileShop_Clientside_StateManagement.CreateCookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 957px;
            height: 524px;
            background-color: #66FFCC;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="2">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="40px" Font-Underline="True" Text="Mobile Shop"></asp:Label>
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <asp:Image ID="Image1" runat="server" Height="200px" ImageUrl="~/Images/Mobile.jpg" Width="800px" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="20px" Font-Underline="True" Text="Model's Name"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                            <asp:ListItem Value="Samsang"></asp:ListItem>
                            <asp:ListItem Value="Vivo"></asp:ListItem>
                            <asp:ListItem Value="Blueberry"></asp:ListItem>
                            <asp:ListItem Value="one_Plus"></asp:ListItem>
                            <asp:ListItem Value="Nokia"></asp:ListItem>
                            <asp:ListItem Value="Redmii"></asp:ListItem>
                            <asp:ListItem Value="Realme"></asp:ListItem>
                            <asp:ListItem Value="Moto"></asp:ListItem>
                            <asp:ListItem Value="Lava"></asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Selected Products" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
