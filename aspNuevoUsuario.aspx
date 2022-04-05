<%@ Page Title="" Language="C#" MasterPageFile="~/master_Principal.Master" AutoEventWireup="true" CodeBehind="aspNuevoUsuario.aspx.cs" Inherits="wsCompras_Hgo.Formulario_web116" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;" id="main">
        <tr>
            <th colspan="5" style="text-align:left;"><h1>Nuevo usuario</h1></th>
        </tr>
               <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Usuario: <span style="color:red">*</span></td>
            <td colspan="3" style="text-align:left">
                <input id="txtUsuario" type="text" placeholder="Nombre de usuario" required="required" /></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Nombre: <span style="color:red">*</span> </td>
            <td colspan="3" style="text-align:left">
                <input id="txtNombre" type="text" placeholder="Nombre completo" required="required" />
            </td>
        </tr>
        <tr>
            <td colspan="2" style="font-family: Arial; width: 20%">Contraseña: <span style="color:red">*</span></td>
            <td colspan="3" style="text-align: left">
                <input id="txtContra" type="text" placeholder="Contraseña" required="required" /></td>

        </tr>
        <tr>
            <td colspan="2" style="font-family: Arial; width: 20%">Userlevel: <span style="color:red">*</span></td>
            <td colspan="3" style="text-align: left">
                <asp:DropDownList ID="dwlUserlevel" runat="server"></asp:DropDownList></td>
        </tr>
         <tr>
             <td colspan="2" style="font-family: Arial; width: 20%">Plaza: <span style="color:red">*</span></td>
             <td colspan="3" style="text-align: left">
                 <asp:DropDownList ID="dwlPlaza" runat="server"></asp:DropDownList></td>
         </tr>
         <tr>
             <td colspan="2" style="font-family: Arial; width: 20%">Área: <span style="color:red">*</span></td>
             <td colspan="3" style="text-align: left">
                 <asp:DropDownList ID="dwlArea" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dwlArea_SelectedIndexChanged"></asp:DropDownList></td>
         </tr>
         <tr>
             <td colspan="2" style="font-family: Arial; width: 20%">Subarea: </td>
             <td colspan="3" style="text-align: left">
                 <asp:DropDownList ID="dwlSubarea" runat="server"></asp:DropDownList></td>
         </tr>
        <tr>
             <td colspan="2" style="font-family: Arial; width: 20%">Puesto: <span style="color:red">*</span></td>
             <td colspan="3" style="text-align: left">
                 <asp:DropDownList ID="dwlPuesto" runat="server"></asp:DropDownList></td>
         </tr>
          <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Email: </td>
            <td colspan="3" style="text-align:left">
                <input id="txtEmail" type="text" placeholder="Escribe un email" /></td>
        </tr>
         <tr>
             <td colspan="2" style="font-family: Arial; width: 20%">Status: <span style="color:red">*</span></td>
             <td colspan="3" style="text-align: left">
                 <asp:DropDownList ID="dwlStatus" runat="server">
                     <asp:ListItem>Activo</asp:ListItem>
                     <asp:ListItem>Inactivo</asp:ListItem>
                 </asp:DropDownList></td>
         </tr>
        <tr>
            <td colspan="5" style="text-align:center">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" /> &nbsp&nbsp&nbsp&nbsp
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClientClick="JavaScript:window.history.back(1); return false;" /></td>
        </tr>
        </table>
</asp:Content>
