<%@ Page Title="" Language="C#" MasterPageFile="~/RRMM/master_RRMM.Master" AutoEventWireup="true" CodeBehind="aspActPartidaRRMM.aspx.cs" Inherits="wsCompras_Hgo.RRMM.Formulario_web111" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;" id="main">
        <tr>
            <th colspan="2" style="text-align: left;">
                <h1>Actualizar Partida</h1>
            </th>
        </tr>
        <tr>
            <td>Requisición: </td>
            <td>
                <asp:TextBox ID="txtRequi" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" /></td>
        </tr>
    </table>
    <table style="width:100%;" id="main">
        <tr>
            <td>
                <asp:Label ID="lblRequis" runat="server" Visible="False" CssClass="subtitulo"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="grdRequi" runat="server">
                    <columns>
                    <asp:HyperLinkField Text="Editar" DataNavigateUrlFields="FOLIO" HeaderText=""
                    DataNavigateUrlFormatString="aspEditarPartida.aspx?folio={0}"
                     NavigateUrl="aspEditarPartida.aspx?folio={0}"/>
                        </columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
