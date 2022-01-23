<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Linq_Example.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 629px;
            height: 485px;
        }
        .auto-style2 {
            width: 1px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
      
        <table class="auto-style1">
            <tr>
                <td colspan="5">simple query&nbsp; var result = from n in nums<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; select n;</td>
                <td colspan="5">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="5">var r = from d in digits<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; select d;</td>
                <td colspan="5">
                    <asp:DropDownList ID="DropDownList2" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="5">unique factor</td>
                <td colspan="5">
                    <asp:DropDownList ID="DropDownList3" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="5">union&nbsp; of two array</td>
                <td colspan="5">
                    <asp:DropDownList ID="DropDownList4" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="5">intersect of two array</td>
                <td colspan="5">
                    <asp:DropDownList ID="DropDownList5" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="5">Except of other array</td>
                <td colspan="5">
                    <asp:DropDownList ID="DropDownList6" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="5">Aggregate function</td>
                <td colspan="5">&nbsp;</td>
            </tr>
            <tr>
                <td>max</td>
                <td colspan="2">min</td>
                <td colspan="4">sum</td>
                <td colspan="2">Avg</td>
                <td>count</td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2">
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="5">All is used line OR</td>
                <td colspan="5">All is used line AND</td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                </td>
                <td colspan="5">
                    <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="5">&nbsp;</td>
                <td colspan="5">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="5">&nbsp;</td>
                <td colspan="5">&nbsp;</td>
            </tr>
        </table>
      
    </form>
</body>
</html>
