<%@ Page Title="" Language="C#" MasterPageFile="~/DM/maestra_DM.Master" AutoEventWireup="true" CodeBehind="aspEnComprasDM.aspx.cs" Inherits="wsCompras_Hgo.DM.Formulario_web12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table style="width:100%;" id="main">
         <tr>
             <th colspan="5" style="text-align:left;"><h1>En Compras</h1></th>
         </tr>
        <tr>
            <td>
                <asp:Label ID="lblRequis" runat="server" Visible="False" CssClass="subtitulo"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="grdRequi" runat="server">
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
