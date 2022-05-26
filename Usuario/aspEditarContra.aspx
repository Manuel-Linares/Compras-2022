<%@ Page Title="" Language="C#" MasterPageFile="~/Usuario/master_Usuario.Master" AutoEventWireup="true" CodeBehind="aspEditarContra.aspx.cs" Inherits="wsCompras_Hgo.Usuario.Formulario_web18" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <table style="width: 100%;" id="main">
        <tr>
            <th colspan="5" style="text-align: left;">
                <h1>Reestablecer contraseña</h1>
            </th>
        </tr>
        <tr>
            <td colspan="2" style="font-family: Arial; width: 20%">Nueva contraseña:<span style="color: red">*</span></td>
            <td colspan="3" style="text-align: left">
                <input type="password" name="password" id="password" onchange='check_pass();' /></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family: Arial; width: 20%">Confirmar contraseña:<span style="color: red">*</span></td>
            <td colspan="3" style="text-align: left">
                <input type="password" name="confirm_password" id="confirm_password" onchange='check_pass();' /></td>
        </tr>
        <tr>
            <td colspan="5" style="text-align: center">
                <input type="submit" name="submit" value="Guardar" id="submit" disabled />
                &nbsp&nbsp&nbsp&nbsp
                <asp:Button ID="Button2" runat="server" Text="Cancelar" /></td>
        </tr>
    </table>
    <script type="text/javascript">
        function check_pass() {
            if (document.getElementById('password').value ==
                document.getElementById('confirm_password').value) {
                document.getElementById('submit').disabled = false;
            }
            else {
                document.getElementById('submit').disabled = true;
            }
        }
    </script>
</asp:Content>
