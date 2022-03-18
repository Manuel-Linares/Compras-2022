﻿<%@ Page Title="" Language="C#" MasterPageFile="~/master_Principal.Master" AutoEventWireup="true" CodeBehind="aspNuevoProveedor.aspx.cs" Inherits="wsCompras_Hgo.Formulario_web110" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;" id="main">
        <tr>
            <th colspan="5" style="text-align: left;">
                <h1>Proveedor</h1>
            </th>
        </tr>
        <tr>
            <td colspan="2" style="font-family: Arial; width: 20%">Nombre <span style="color:red">*</span></td>
            <td colspan="3" style="text-align: left">
                <asp:TextBox ID="txtNombre" runat="server" Width="50%"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family: Arial; width: 20%">Tipo Tercero</td>
            <td colspan="3" style="text-align: left">
                <asp:TextBox ID="txtTipo" runat="server" Width="50%"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family: Arial; width: 20%">RFC <span style="color:red">*</span></td>
            <td colspan="3" style="text-align: left">
                <asp:TextBox ID="txtRFC" runat="server" Width="50%"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family: Arial; width: 20%">CURP</td>
            <td colspan="3" style="text-align: left">
                <asp:TextBox ID="txtCURP" runat="server" Width="50%"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family: Arial; width: 20%">Dirección</td>
            <td colspan="3" style="text-align: left">
                <asp:TextBox ID="txtDireccion" runat="server" Width="50%"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family: Arial; width: 20%">Contacto</td>
            <td colspan="3" style="text-align: left">
                <asp:TextBox ID="txtContacto" runat="server" TextMode="MultiLine" Width="50%"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family: Arial; width: 20%">Teléfono</td>
            <td colspan="3" style="text-align: left">
                <asp:TextBox ID="txtTelefono" runat="server" Width="50%"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family: Arial; width: 20%">Email</td>
            <td colspan="3" style="text-align: left">
                <asp:TextBox ID="txtEmail" runat="server" Width="50%"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="5" style="text-align:center">
                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" /></td>
        </tr>
    </table>
</asp:Content>
