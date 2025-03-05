<%@ Page Title="" Language="C#" MasterPageFile="~/master_Principal.Master" AutoEventWireup="true" CodeBehind="aspRequiRev.aspx.cs" Inherits="wsCompras_Hgo.Formulario_web16" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;" id="main">
         <tr>
             <th colspan="5" style="text-align:left;"><h1>Revisión</h1></th>
         </tr>
        <tr>
            <td>
                <asp:Label ID="lblRequis" runat="server" Visible="False" CssClass="subtitulo"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="grdRequi" runat="server" AllowPaging="True" AllowSorting="True" OnPageIndexChanging="grdRequi_PageIndexChanging" OnSorting="grdRequi_Sorting" CssClass="gv">
                    <SortedAscendingHeaderStyle CssClass="sort_asc" />
                    <SortedDescendingHeaderStyle CssClass="sort_desc" />
                    <%--<columns>
                    <asp:HyperLinkField Text="Actualizar" DataNavigateUrlFields="FOLIO" HeaderText=""
                    DataNavigateUrlFormatString="aspEditarRevRRMM.aspx?folio={0}"
                     NavigateUrl="aspEditarRevRRMM.aspx?folio={0}"/>
                        </columns>--%>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
