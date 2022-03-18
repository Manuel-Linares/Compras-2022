<%@ Page Title="" Language="C#" MasterPageFile="~/RRMM/master_RRMM.Master" AutoEventWireup="true" CodeBehind="aspODCAutorizadas.aspx.cs" Inherits="wsCompras_Hgo.RRMM.Formulario_web117" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;" id="main">
         <tr>
             <th colspan="5" style="text-align:left;"><h1>ODC Autorizadas</h1></th>
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
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
