<%@ Page Title="" Language="C#" MasterPageFile="~/master_Principal.Master" AutoEventWireup="true" CodeBehind="aspABCUsuarios.aspx.cs" Inherits="wsCompras_Hgo.Formulario_web114" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;" id="main">
         <tr>
             <th colspan="5" style="text-align:left;"><h1>ABC Usuarios</h1></th>
         </tr>
        <tr>
            <td>
                <asp:Label ID="lblRequis" runat="server" Visible="False" CssClass="subtitulo"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="grdUsu" class="table table-bordered table-condensed table-hover" runat="server" AllowPaging="True" AllowSorting="True" OnPageIndexChanging="grdUsu_PageIndexChanging" OnSorting="grdUsu_Sorting" PageSize="15">
                    <SortedAscendingHeaderStyle CssClass="sort_asc" />
                    <SortedDescendingHeaderStyle CssClass="sort_desc" />
                    <Columns>
                        <asp:HyperLinkField Text="Editar" DataNavigateUrlFields="ID" HeaderText=""
                            DataNavigateUrlFormatString="aspEditarUsuario.aspx?id={0}"
                            NavigateUrl="aspEditarUsuario.aspx?id={0}" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
