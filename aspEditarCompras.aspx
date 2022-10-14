<%@ Page Title="" Language="C#" MasterPageFile="~/master_Principal.Master" AutoEventWireup="true" CodeBehind="aspEditarCompras.aspx.cs" Inherits="wsCompras_Hgo.Formulario_web121" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;" id="main">
        <tr>
            <th colspan="5" style="text-align:left;"><h1>Compras: Autorizar</h1></th>
        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Folio: </td>
            <td colspan="3" style="text-align:left">
                <asp:Label ID="lblFolio" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
             <td colspan="2" style="font-family: Arial; width: 20%">Fecha Creación: </td>
             <td colspan="3" style="text-align: left">
                 <asp:Label ID="lblFechaCreacion" runat="server" Text="Label"></asp:Label></td>
        </tr>
         <tr>
            <td colspan="2" style="font-family: Arial; width: 20%">Fecha Autorización: </td>
            <td colspan="3" style="text-align: left">
                <asp:Label ID="lblFechaAutorizacion" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family: Arial; width: 20%">Fecha Necesidad: </td>
            <td colspan="3" style="text-align: left">
                <asp:Label ID="lblFechaNecesidad" runat="server" Text="Label"></asp:Label></td>
        </tr>
         <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Area: </td>
            <td colspan="3" style="text-align:left">
                <asp:Label ID="lblArea" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Usuario: </td>
            <td colspan="3" style="text-align:left">
                <asp:Label ID="lblUsuario" runat="server" Text="Label"></asp:Label></td>
        </tr>
       <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Cuenta: </td>
            <td colspan="3" style="text-align:left">
                <asp:Label ID="lblCuenta" runat="server" Text="Label"></asp:Label></td>
        </tr>
         <tr>
             <td colspan="2" style="font-family: Arial; width: 20%">Observaciones: </td>
             <td colspan="3" style="text-align: left">
                 <asp:Label ID="lblObservaciones" runat="server" Text="Label"></asp:Label></td>
         </tr>
         <tr>
             <td colspan="2" style="font-family: Arial; width: 20%">Observaciones Dirección: </td>
             <td colspan="3" style="text-align: left">
                 <asp:Label ID="lblObserDireccion" runat="server" Text="Label"></asp:Label></td>
         </tr>
         <tr>
             <td colspan="2" style="font-family: Arial; width: 20%">Observaciones RM: </td>
             <td colspan="3" style="text-align: left">
                 <asp:Label ID="lblObserRM" runat="server" Text="Label"></asp:Label></td>
         </tr>
         <tr>
             <td colspan="2" style="font-family: Arial; width: 20%">Prioridad: </td>
             <td colspan="3" style="text-align: left">
                 <asp:Label ID="lblPrioridad" runat="server" Text="Label"></asp:Label></td>
         </tr>
         <tr>
             <td colspan="2" style="font-family: Arial; width: 20%">CAUS Origen: </td>
             <td colspan="3" style="text-align: left">
                 <asp:Label ID="lblCaus" runat="server" Text="Label"></asp:Label></td>
         </tr>
         <tr>
             <td colspan="2" style="font-family: Arial; width: 20%">Requisición: </td>
             <td colspan="3" style="text-align: left">
                 <asp:Label ID="lblRequi" runat="server" Text="Label"></asp:Label></td>
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
