<%@ Page Title="" Language="C#" MasterPageFile="~/Compras/master_Compras.Master" AutoEventWireup="true" CodeBehind="aspODCImpuestosCom.aspx.cs" Inherits="wsCompras_Hgo.Compras.Formulario_web117" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;" id="main">
        <tr>
            <th colspan="3" style="text-align: left;">
                <h1>ODC Impuestos</h1>
            </th>
        </tr>
        <tr>
            <td colspan="1" style="width: 25%">Orden de Compra autorizada: </td>
            <td colspan="2">
                <asp:DropDownList ID="dwlODC" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td colspan="1" style="width: 25%">Tipo de impuesto: </td>
            <td colspan="2">
                <asp:DropDownList ID="dwlTipo" runat="server">
                    <asp:ListItem>IEPS</asp:ListItem>
                    <asp:ListItem>ISR</asp:ListItem>
                    <asp:ListItem Value="Retención+de+IVA">Retención de IVA</asp:ListItem>
                    <asp:ListItem Value="Impuesto+Sobre+Hospedaje">Impuesto Sobre Hospedaje</asp:ListItem>
                    <asp:ListItem Value="Descuento">Descuento</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td colspan="1" style="width: 25%">Monto del impuesto: </td>
            <td colspan="2">
                <asp:TextBox ID="txtMonto" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="1" style="width: 25%">IVA: </td>
            <td colspan="2">
                <asp:TextBox ID="txtIVA" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Button ID="btnBuscar" runat="server" Text="Generar" OnClick="btnBuscar_Click" /></td>
            &nbsp;&nbsp;<asp:Label ID="lblMensaje" runat="server" Text="[Mensaje]" CssClass="subtitulo" Visible="False"></asp:Label>
        </tr>
    </table>
</asp:Content>
