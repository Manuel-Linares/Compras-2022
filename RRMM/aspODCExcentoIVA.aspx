<%@ Page Title="" Language="C#" MasterPageFile="~/RRMM/master_RRMM.Master" AutoEventWireup="true" CodeBehind="aspODCExcentoIVA.aspx.cs" Inherits="wsCompras_Hgo.RRMM.Formulario_web118" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;" id="main">
        <tr>
            <th colspan="3" style="text-align: left;">
                <h1>ODC Excento de IVA</h1>
            </th>
        </tr>
        <tr>
            <td colspan="1" style="width:25%">Orden de Compra: </td>
            <td colspan="2">
                <asp:DropDownList ID="dwlODC" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Button ID="btnBuscar" runat="server" Text="Generar" OnClick="btnBuscar_Click" /></td>&nbsp;&nbsp;<asp:Label ID="lblMensaje" runat="server" Text="[Mensaje]" CssClass="subtitulo" Visible="False"></asp:Label>
        </tr>
    </table>
</asp:Content>
