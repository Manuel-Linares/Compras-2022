<%@ Page Title="" Language="C#" MasterPageFile="~/Compras/master_Compras.Master" AutoEventWireup="true" CodeBehind="aspODCRevisionCom.aspx.cs" Inherits="wsCompras_Hgo.Compras.Formulario_web114" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;" id="main">
         <tr>
             <th colspan="5" style="text-align:left;"><h1>ODC en Revisión</h1></th>
         </tr>
        <tr>
            <td>
                <asp:Label ID="lblRequis" runat="server" Visible="False" CssClass="subtitulo"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="grdODC" runat="server" AllowSorting="True" OnSorting="grdODC_Sorting" CssClass="gv">
                    <SortedAscendingHeaderStyle CssClass="sort_asc" />
                    <SortedDescendingHeaderStyle CssClass="sort_desc" />
                    <columns>
                    <asp:HyperLinkField Text="Actualizar" DataNavigateUrlFields="Folio ODC" HeaderText="Folio ODC"
                    DataNavigateUrlFormatString="aspEditarODCCom.aspx?id={0}"
                     NavigateUrl="aspEditarODCCom.aspx?id={0}"/>
                        </columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
