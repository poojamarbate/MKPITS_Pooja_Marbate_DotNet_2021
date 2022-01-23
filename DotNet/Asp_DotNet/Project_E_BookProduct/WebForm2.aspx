<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Project_E_BookProduct.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style2 {
        width: 261px;
        border-color: #CCCCCC;
    }
    .auto-style4 {
        height: 33px;
    }
    .auto-style5 {
        width: 131px;
    }
    .auto-style6 {
        height: 24px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style2">
    <tr>
        <td class="auto-style4" colspan="2">
            <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="25px" Font-Underline="True" Text="Book Categories "></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">
            <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="20px" Font-Underline="False" Text="BookID:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">
            <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="20px" Font-Underline="False" Text="Book Categories :"></asp:Label>
        </td>
        <td>
            

            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            

        </td>
    </tr>
    <tr>
        <td class="auto-style4" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" BackColor="Black" ForeColor="White" Text="ADD" OnClick="Button1_Click" />
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style6" colspan="2">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Llbmessage" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="15px" Font-Underline="False" Text=".............."></asp:Label>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>
