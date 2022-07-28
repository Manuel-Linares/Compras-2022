<%@ Page Title="" Language="C#" MasterPageFile="~/Compras/master_Compras.Master" AutoEventWireup="true" CodeBehind="aspEditarODCCom.aspx.cs" Inherits="wsCompras_Hgo.Compras.Formulario_web122" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;" id="main">
        <tr>
            <th colspan="5" style="text-align:left;"><h1>Orden de Compra RRMM: Autorizar</h1></th>
        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Folio ODC: </td>
            <td colspan="3" style="text-align:left">
                <asp:Label ID="lblFolio" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Fecha Creación: </td>
            <td colspan="3" style="text-align:left">
                <asp:Label ID="lblFechaCreacion" runat="server" Text="Label"></asp:Label></td>

        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Proveedor </td>
            <td colspan="3" style="text-align:left">
                <asp:Label ID="lblProveedor" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Contacto: </td>
            <td colspan="3" style="text-align:left">
                <asp:Label ID="lblContacto" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Consignar a: </td>
            <td colspan="3" style="text-align:left">
                <asp:Label ID="lblConsignar" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Fecha Embarque: </td>
            <td colspan="3" style="text-align:left">
                <asp:Label ID="lblFechaEmbarque" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Área: </td>
            <td colspan="3" style="text-align:left">
                <asp:Label ID="lblArea" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Centro de Costos: </td>
            <td colspan="3" style="text-align:left">
                <asp:Label ID="lblCentroCostos" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Observaciones: </td>
            <td colspan="3" style="text-align:left">
                <asp:Label ID="lblObservaciones" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="5">
                <asp:GridView ID="grdPart" runat="server">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Comentarios RRMM: </td>
            <td colspan="3" style="text-align:left">
                <asp:TextBox ID="txtComentariosRRMM" runat="server" TextMode="MultiLine"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Estatus: <span style="color:red">*</span> </td>
            <td colspan="3" style="text-align:left">
                <asp:DropDownList ID="dwlEstatus" AutoPostBack="true" runat="server" Width="50%"></asp:DropDownList></td>
        </tr>
        <tr>
            <td colspan="5" style="text-align:center">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click"/> &nbsp&nbsp&nbsp&nbsp
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" /></td>
        </tr>
        </table>
</asp:Content>
