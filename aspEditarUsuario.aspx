<%@ Page Title="" Language="C#" MasterPageFile="~/master_Principal.Master" AutoEventWireup="true" CodeBehind="aspEditarUsuario.aspx.cs" Inherits="wsCompras_Hgo.Formulario_web115" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;" id="main">
        <tr>
            <th colspan="5" style="text-align:left;"><h1>Editar usuario</h1></th>
        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Id: </td>
            <td colspan="3" style="text-align:left">
                <asp:Label ID="lblId" runat="server" Text="[Id]"></asp:Label></td>
        </tr>
               <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Usuario: </td>
            <td colspan="3" style="text-align:left">
                <asp:Label ID="lblUsuario" runat="server" Text="[Usuario]"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Nombre: <span style="color:red">*</span> </td>
            <td colspan="3" style="text-align:left">
                <asp:TextBox ID="txtNombre" runat="server" placeholder="Nombre"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Contraseña: </td>
            <td colspan="3" style="text-align:left">
               <asp:TextBox ID="txtContra" runat="server" placeholder="Contraseña" TextMode="Password"></asp:TextBox> </td>

        </tr>
        <tr>
            <td colspan="2" style="font-family: Arial; width: 20%">Userlevel: </td>
            <td colspan="3" style="text-align: left">
                <asp:DropDownList ID="dwlUserlevel" runat="server"></asp:DropDownList></td>
        </tr>
         <tr>
             <td colspan="2" style="font-family: Arial; width: 20%">Plaza: </td>
             <td colspan="3" style="text-align: left">
                 <asp:DropDownList ID="dwlPlaza" runat="server"></asp:DropDownList></td>
         </tr>
         <tr>
             <td colspan="2" style="font-family: Arial; width: 20%">Área: </td>
             <td colspan="3" style="text-align: left">
                 <asp:DropDownList ID="dwlArea" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dwlArea_SelectedIndexChanged"></asp:DropDownList></td>
         </tr>
         <tr>
             <td colspan="2" style="font-family: Arial; width: 20%">Subarea: </td>
             <td colspan="3" style="text-align: left">
                 <asp:DropDownList ID="dwlSubarea" runat="server"></asp:DropDownList></td>
         </tr>
        <tr>
             <td colspan="2" style="font-family: Arial; width: 20%">Puesto: </td>
             <td colspan="3" style="text-align: left">
                 <asp:DropDownList ID="dwlPuesto" runat="server"></asp:DropDownList></td>
         </tr>
          <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Email: </td>
            <td colspan="3" style="text-align:left">
                <asp:TextBox ID="txtEmail" runat="server" placeholder="Email"></asp:TextBox></td>
        </tr>
         <tr>
             <td colspan="2" style="font-family: Arial; width: 20%">Status: </td>
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
