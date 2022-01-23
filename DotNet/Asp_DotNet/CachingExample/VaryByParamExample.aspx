<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VaryByParamExample.aspx.cs" Inherits="CachingExample.VaryByParam" %>
<%@ OutputCache  Duration="10"  VaryByParam="Category" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 374px;
            height: 217px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>Caching - Creating multiple version of Cahed page using varybyparams<br />
                        <br />
                        this is non cached page<br />
                        <br />
                        <asp:Label ID="Label1" runat="server" ForeColor="#FF3300" Text="Click below to go next"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Books.aspx?Category=Cooking">Cooking</asp:HyperLink>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Books.aspx?Category=Art">Art&amp;Craft</asp:HyperLink>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Books.aspx?Category=Puzzles">Puzzles</asp:HyperLink>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Books.aspx?Category=Story">Story</asp:HyperLink>
                    </td>
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
