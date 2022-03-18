<%@ Page Title="Inicio" Language="C#" MasterPageFile="~/acceso.Master" AutoEventWireup="true" CodeBehind="aspInicio.aspx.cs" Inherits="wsCompras_Hgo.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/acceso.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;" id="acceso">
        <tr>
            <td>Usuario: </td>
            <td>
                <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Contraseña: </td>
            <td>
                <asp:TextBox ID="txtContra" runat="server" TextMode="Password" ></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" style="text-align:center">
                <asp:Button ID="btnInicio" runat="server" Text="Iniciar Sesión" OnClick="btnInicio_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
