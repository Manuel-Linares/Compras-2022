<%@ Page Title="" Language="C#" MasterPageFile="~/RRMM/master_RRMM.Master" AutoEventWireup="true" CodeBehind="aspEditarRevRRMM.aspx.cs" Inherits="wsCompras_Hgo.RRMM.Formulario_web126" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;" id="main">
        <tr>
            <th colspan="5" style="text-align:left;"><h1>Recursos Materiales: Autorizar</h1></th>
        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Folio: </td>
            <td colspan="3" style="text-align:left">
                <asp:Label ID="lblFolio" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Nombre: </td>
            <td colspan="3" style="text-align:left">
                <asp:Label ID="lblNombre" runat="server" Text="Label"></asp:Label></td>
        </tr>
       <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Cuenta: </td>
            <td colspan="3" style="text-align:left">
                <asp:Label ID="lblCuenta" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Fecha Creación: </td>
            <td colspan="3" style="text-align:left">
                <asp:Label ID="lblFechaCreacion" runat="server" Text="Label"></asp:Label></td>

        </tr>
        <tr>
            <td colspan="2" style="font-family: Arial; width: 20%">Fecha Estimada: </td>
            <td colspan="3" style="text-align: left">
                <asp:Label ID="lblFechaEstimada" runat="server" Text="Label"></asp:Label></td>
        </tr>
         <tr>
             <td colspan="2" style="font-family: Arial; width: 20%">Observaciones: </td>
             <td colspan="3" style="text-align: left">
                 <asp:Label ID="lblObservaciones" runat="server" Text="Label"></asp:Label></td>
         </tr>
         <tr>
            <td colspan="5">
                <asp:GridView ID="grdPart" runat="server">
                </asp:GridView>
            </td>
        </tr>
         <tr>
             <td colspan="2" style="font-family: Arial; width: 20%">Presupuesto: </td>
             <td colspan="3" style="text-align: left">
                 <asp:Label ID="lblPresupuesto" runat="server" Text="Label"></asp:Label></td>
         </tr>
         <tr>
             <td colspan="2" style="font-family: Arial; width: 20%">Costo Aproximado: </td>
             <td colspan="3" style="text-align: left">
                 <asp:Label ID="lblCosto" runat="server" Text="Label"></asp:Label></td>
         </tr>
          <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Prioridad: </td>
            <td colspan="3" style="text-align:left">
               <asp:Label ID="lblPrioridad" runat="server" Text="Label"></asp:Label> </td>
        </tr>
         <tr>
             <td colspan="2" style="font-family: Arial; width: 20%">Observaciones DG: </td>
            <td colspan="3" style="text-align:left">
                <asp:TextBox ID="txtObservacionesDG" runat="server" TextMode="MultiLine"></asp:TextBox></td>
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
