<%@ Page Title="" Language="C#" MasterPageFile="~/Sistemas/maestra_Sistemas.Master" AutoEventWireup="true" CodeBehind="aspRequiRev.aspx.cs" Inherits="wsCompras_Hgo.Sistemas.Formulario_web14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblRequis" runat="server" Text=""></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="grdRequi" runat="server" AllowPaging="True" OnPageIndexChanging="grdRequi_PageIndexChanging">
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
