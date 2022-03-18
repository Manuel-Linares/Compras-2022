<%@ Page Title="" Language="C#" MasterPageFile="~/RRMM/master_RRMM.Master" AutoEventWireup="true" CodeBehind="aspRequiRRMM.aspx.cs" Inherits="wsCompras_Hgo.RRMM.Formulario_web18" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" id="main">
        <tr>
            <th colspan="5" style="text-align: left;">
                <h1>Requisiciones por autorizar</h1>
            </th>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblRequis" runat="server" Visible="False" CssClass="subtitulo"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                 <asp:GridView ID="grdRequi" runat="server" runat="server" AllowPaging="True" AllowSorting="True" OnPageIndexChanging="grdRequi_PageIndexChanging" OnSorting="grdRequi_Sorting" CssClass="gv">
                     <SortedAscendingHeaderStyle CssClass="sort_asc" />
                    <SortedDescendingHeaderStyle CssClass="sort_desc" />
                     <columns>
                    <asp:HyperLinkField Text="Actualizar" DataNavigateUrlFields="FOLIO" HeaderText=""
                    DataNavigateUrlFormatString="aspEditarRequiRRMM.aspx?folio={0}"
                     NavigateUrl="aspEditarRequiRRMM.aspx?folio={0}"/>
                        </columns>
                 </asp:GridView>
             </td>
        </tr>
    </table>
</asp:Content>
