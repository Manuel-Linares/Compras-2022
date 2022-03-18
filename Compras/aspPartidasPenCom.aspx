<%@ Page Title="" Language="C#" MasterPageFile="~/Compras/master_Compras.Master" AutoEventWireup="true" CodeBehind="aspPartidasPenCom.aspx.cs" Inherits="wsCompras_Hgo.Compras.Formulario_web110" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;"; id="main">
        <tr>
             <th colspan="5" style="text-align:left;"><h1>Partidas Pendientes</h1></th>
         </tr>
        <tr>
            <td colspan="5">
                <asp:Label ID="lblRequis" runat="server" Visible="False" CssClass="subtitulo"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="5">Filtrar por: 
                <asp:RadioButton ID="rdbRequi" runat="server" GroupName="1" AutoPostBack="True" />Requisición<asp:RadioButton ID="rdbPartida" runat="server" GroupName="1" AutoPostBack="True"/>Partida</td>
        </tr>
        <tr>
            <td colspan="5">
                <asp:TextBox ID="txtFiltro" runat="server"></asp:TextBox>&nbsp;<asp:Button ID="btnFiltro" runat="server" Text="Buscar" OnClick="btnFiltro_Click" />&nbsp;<asp:Button ID="btnTodos" runat="server" Text="Limpiar Filtro" OnClick="btnTodos_Click" />
                <%--asp:DropDownList ID="dwlFiltro" runat="server"></asp:DropDownList>&nbsp;&nbsp;<asp:Button ID="btnFiltro" runat="server" Text="Buscar" OnClick="btnFiltro_Click" />&nbsp;&nbsp;<asp:Button ID="btnTodos" runat="server" Text="Limpiar Filtro" OnClick="btnTodos_Click" />--%>
                    </td>
        </tr>
         <tr>
             <td colspan="5">
                 <asp:GridView ID="grdRequi" runat="server" AllowPaging="True" AllowSorting="True" OnPageIndexChanging="grdRequi_PageIndexChanging" OnSorting="grdRequi_Sorting" CssClass="gv" PageSize="30" PagerSettings-Position="TopAndBottom">
                     <columns>
                    <asp:HyperLinkField Text="Actualizar" DataNavigateUrlFields="Folio Requisición" HeaderText=""
                    DataNavigateUrlFormatString="aspEditarPartPendiente.aspx?folio={0}"
                     NavigateUrl="aspEditarPartPendiente.aspx?folio={0}"/>
                        </columns>
                     <SortedAscendingHeaderStyle CssClass="sort_asc" />
                    <SortedDescendingHeaderStyle CssClass="sort_desc" />
                 </asp:GridView>
             </td>
        </tr>
    </table>
</asp:Content>
