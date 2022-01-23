<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Create_MasterPage_example.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100px">
    <tr>
        <td colspan="2">
            <asp:Label ID="Label3" runat="server" Text="Products"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:ListBox ID="ListBox1" runat="server">
                <asp:ListItem Value="Westan"></asp:ListItem>
                <asp:ListItem Value="Indian"></asp:ListItem>
                <asp:ListItem Value="SouthIndian"></asp:ListItem>
                <asp:ListItem Value="Bollywood"></asp:ListItem>
                <asp:ListItem Value="IndioWesten"></asp:ListItem>
                <asp:ListItem Value="Trandy"></asp:ListItem>
                <asp:ListItem Value="Formals"></asp:ListItem>
                <asp:ListItem Value="Party ware"></asp:ListItem>
                <asp:ListItem Value="Office wear"></asp:ListItem>
            </asp:ListBox>
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
</table>
</asp:Content>
