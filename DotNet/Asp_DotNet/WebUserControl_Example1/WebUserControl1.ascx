<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="WebUserControl_Example1.WebUserControl1" %>
<%@ OutputCache Duration="120" VaryByControl="ddlCountry;ddlState" Shared="true"%>

<table class="style2" style="border: medium solid #0000FF">
        <tr>
            <td class="style3">
                Choose state :
            </td>
            <td>
                <asp:DropDownList ID="ddlCountry" runat="server">
               
               
      <asp:ListItem>Austria</asp:ListItem>
      <asp:ListItem>France</asp:ListItem>
      <asp:ListItem>Italy</asp:ListItem>
      <asp:ListItem>Germany</asp:ListItem>
      <asp:ListItem>Spain</asp:ListItem>
      <asp:ListItem>Switzerland</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Choose City&nbsp;&nbsp; :
            </td>
            <td>
                <asp:DropDownList ID="ddlState" runat="server">
                   
            <asp:ListItem>Idaho</asp:ListItem>
            <asp:ListItem>Montana</asp:ListItem>
            <asp:ListItem>Nevada</asp:ListItem>
            <asp:ListItem>Oregon</asp:ListItem>
            <asp:ListItem>Washington</asp:ListItem>
            <asp:ListItem>Wyoming</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit"
                    onclick="btnSubmit_Click" />
            </td>
        </tr>
        <tr>
            <td class="style3">
                <asp:Label ID="lbltime" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblPlaces" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
