<%@ Page Title="" Language="C#" MasterPageFile="~/Compras/master_Compras.Master" AutoEventWireup="true" CodeBehind="aspEditarPartida.aspx.cs" Inherits="wsCompras_Hgo.Compras.Formulario_web120" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table style="width:100%;" id="main">
        <tr>
            <th colspan="5" style="text-align:left;"><h1>Actualizar partida</h1></th>
        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Requisición: </td>
            <td colspan="3" style="text-align:left">
                <asp:Label ID="lblRequi" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Folio Partida: </td>
            <td colspan="3" style="text-align:left">
                <asp:Label ID="lblFolio" runat="server" Text="Label"></asp:Label></td>
        </tr>
       <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Descripción: </td>
            <td colspan="3" style="text-align:left">
                <asp:Label ID="lblDescripcion" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Cantidad: </td>
            <td colspan="3" style="text-align:left">
                <asp:Label ID="lblCantidad" runat="server" Text="Label"></asp:Label></td>

        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">U. de Medición: </td>
            <td colspan="3" style="text-align:left">
                <asp:Label ID="lblUDeMedicion" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Comentarios Compras: </td>
            <td colspan="3" style="text-align:left">
                <asp:TextBox ID="txtComenCompras" runat="server" TextMode="MultiLine"></asp:TextBox></td>
        </tr>
         <tr>
             <td colspan="2" style="font-family:Arial; width:20%">Orden de Compra: </td>
            <td colspan="3" style="text-align:left">
                <asp:FileUpload ID="fupOrdenDeCompra" runat="server" />
         </tr>
         <tr>
             <td colspan="2" style="font-family:Arial; width:20%">Factura: </td>
            <td colspan="3" style="text-align:left">
                <asp:FileUpload ID="fupFactura" runat="server" />
         </tr>
         <tr>
             <td colspan="2" style="font-family:Arial; width:20%">Orden de Pago: </td>
            <td colspan="3" style="text-align:left">
                <asp:FileUpload ID="fupOrdenDePago" runat="server" />
         </tr>
         <tr>
             <td colspan="2" style="font-family:Arial; width:20%">Reembolso: </td>
            <td colspan="3" style="text-align:left">
                <asp:RadioButton ID="rdbSi" runat="server" GroupName="1" />Sí
                <asp:RadioButton ID="rdbNo" runat="server" GroupName="1" />No
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
