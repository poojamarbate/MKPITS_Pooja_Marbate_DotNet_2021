<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ButtonClick.aspx.cs" Inherits="ServerControlExample.ButtonClick" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 664px;
            height: 257px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Button</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" PostBackUrl="~/WebForm1.aspx" Text="Button" />
                    </td>
                    <td>PostBack Url()</td>
                </tr>
                <tr>
                    <td>Link Button</td>
                    <td>
                        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/WebForm1.aspx">LinkButton</asp:LinkButton>
                    </td>
                    <td>PostBack url()</td>
                </tr>
                <tr>
                    <td>Hyperlink</td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebForm1.aspx?Name=Rani">HyperLink</asp:HyperLink>
                    </td>
                    <td>nevigation url()</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
