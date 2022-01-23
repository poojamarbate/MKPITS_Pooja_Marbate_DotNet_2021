<%@ Page Title="" Language="C#" MasterPageFile="~/Car.Master" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="CreateSmall_Project_Using_Asp.net.Category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 209px; height: 239px; background-color: #C0C0C0">
    <tr>
        <td colspan="2">
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="25px" Text="Car Models"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="20px" Text="Car ID"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="20px" Text="Car Name"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Next" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label ID="Llbmessage" runat="server" Font-Bold="True" Font-Size="25px" Text="............."></asp:Label>
            <br />
            <br />
            <br />
            <br />
        </td>
    </tr>
</table>
</asp:Content>
