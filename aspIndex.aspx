<%@ Page Title="" Language="C#" MasterPageFile="~/master_Principal.Master" AutoEventWireup="true" CodeBehind="aspIndex.aspx.cs" Inherits="wsCompras_Hgo.Formulario_web12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td>&nbsp;</td>
            <td style="text-align:center; margin-right:25%"><h2>Bienvenido al sistema de compras</h2></td>
            <td>&nbsp;</td>
        </tr>
        </table>
    <table style="width:100%;">
        <tr>
            <td colspan="3" class="requisiciones">REQUISICIONES</td>
            <%--<td style="text-align:center; margin-right:25%;"><asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/Y2.png" Height="50%"/></td>--%>
        </tr>
        <tr>
            <td colspan="2">Recibidas</td>
            <td style="text-align:left;">
                <asp:Label ID="lblRecibidas" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">En proceso de compra</td>
            <td>
                <asp:Label ID="lblProcCompra" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">Pendientes de Autorizar por Dirección</td>
            <td>
                <asp:Label ID="lblPendAutDir" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">Pendientes de Autorizar por RRMM</td>
            <td>
                <asp:Label ID="lblPendAutRM" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">Reembolso / Servicio</td>
            <td>
                <asp:Label ID="lblReemServ" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">En Revisión</td>
            <td>
                <asp:Label ID="lblRevis" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">No Autorizadas</td>
            <td>
                <asp:Label ID="lblNoAut" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">Finalizadas</td>
            <td>
                <asp:Label ID="lblFinalizadas" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
    <hr />
    <table>
        <tr>
            <td colspan="3" class="requisiciones">PARTIDAS</td>
        </tr>
        <tr>
            <td colspan="2">Total de Partidas Recibidas</td>
            <td>
                <asp:Label ID="lblPartRec" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">Finalizadas</td>
            <td>
                <asp:Label ID="lblPartFin" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">Pendientes</td>
            <td>
                <asp:Label ID="lblPartPend" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">Reembolsos / Servicios</td>
            <td>
                <asp:Label ID="lblReemb" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>

    <hr />
    <table>
        <tr>
            <td colspan="3" class="requisiciones">TIEMPOS DE COMPRA</td>
            <%--<td style="text-align:center; margin-right:25%;"><asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/Y2.png" Height="50%"/></td>--%>
        </tr>
        <tr>
            <td colspan="2">Días promedio por Requisición</td>
            <td>
                <asp:Label ID="lblDiasReq" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">Días promedio por Partida</td>
            <td>
                <asp:Label ID="lblDiasPart" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
    <hr />
    <table>
        <tr>
            <td colspan="3" class="requisiciones">ORDENES DE COMPRA</td>
            <%--<td style="text-align:center; margin-right:25%;"><asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/Y2.png" Height="50%"/></td>--%>
        </tr>
        <tr>
            <td colspan="2">ODC Elaboradss</td>
            <td>
                <asp:Label ID="lblODC" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
    <hr />
    <table>
        <tr>
            <td colspan="3" class="requisiciones">ENLACES</td>
            <%--<td style="text-align:center; margin-right:25%;"><asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/Y2.png" Height="50%"/></td>--%>
        </tr>
        <tr>
            <td colspan="3"><a href="https://verificacfdi.facturaelectronica.sat.gob.mx/" target="_blank">Verificación de comprobantes fiscales por internet</a></td>
        </tr>
        <tr>
            <td colspan="3"><a href="http://104.130.136.166/precom/WpLogin.aspx" target="_blank">PRECOM</a></td>
        </tr>
    </table>
</asp:Content>
