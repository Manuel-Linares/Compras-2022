<%@ Page Title="" Language="C#" MasterPageFile="~/RRMM/master_RRMM.Master" AutoEventWireup="true" CodeBehind="aspComprasRRMM.aspx.cs" Inherits="wsCompras_Hgo.RRMM.Formulario_web110" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;"; id="main">
        <tr>
             <th colspan="5" style="text-align:left;"><h1>Compras</h1></th>
         </tr>
        <tr>
            <td colspan="5">
                <asp:Label ID="lblRequis" runat="server" Visible="False" CssClass="subtitulo"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="5">Filtrar por: 
                <asp:RadioButton ID="rdbUsuario" runat="server" GroupName="1" AutoPostBack="True" OnCheckedChanged="rdbUsuario_CheckedChanged" />Usuario<asp:RadioButton ID="rdbPrioridad" runat="server" GroupName="1" AutoPostBack="True" OnCheckedChanged="rdbPrioridad_CheckedChanged" />Prioridad</td>
        </tr>
        <tr>
            <td colspan="5">
                <asp:DropDownList ID="dwlFiltro" runat="server"></asp:DropDownList>&nbsp;&nbsp;<asp:Button ID="btnFiltro" runat="server" Text="Buscar" OnClick="btnFiltro_Click" />&nbsp;&nbsp;<asp:Button ID="btnTodos" runat="server" Text="Limpiar Filtro" OnClick="btnTodos_Click" /></td>
        </tr>
         <tr>
             <td colspan="5">
                 <asp:GridView ID="grdRequi" runat="server" AllowPaging="True" AllowSorting="True" OnPageIndexChanging="grdRequi_PageIndexChanging" OnSorting="grdRequi_Sorting" CssClass="gv" PageSize="30" PagerSettings-Position="TopAndBottom">
                     <columns>
                    <asp:HyperLinkField Text="Actualizar" DataNavigateUrlFields="FOLIO" HeaderText=""
                    DataNavigateUrlFormatString="aspEditarComprasRRMM.aspx?folio={0}"
                     NavigateUrl="aspEditarComprasRRMM.aspx?folio={0}"/>
                        </columns>
                     <SortedAscendingHeaderStyle CssClass="sort_asc" />
                    <SortedDescendingHeaderStyle CssClass="sort_desc" />
                 </asp:GridView>
             </td>
        </tr>
    </table>
</asp:Content>
