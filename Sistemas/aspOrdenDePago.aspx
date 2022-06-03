<%@ Page Title="" Language="C#" MasterPageFile="~/Sistemas/maestra_Sistemas.Master" AutoEventWireup="true" CodeBehind="aspOrdenDePago.aspx.cs" Inherits="wsCompras_Hgo.Sistemas.Formulario_web18" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;" id="main">
        <tr>
            <th colspan="3" style="text-align: left;">
                <h1>Orden de Pago</h1>
            </th>
        </tr>
        <tr>
            <td colspan="1" style="width: 25%">Requisición: </td>
            <td colspan="2">
                <asp:DropDownList ID="dwlRequi" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td colspan="1" style="width: 25%">Orden de pago (PDF)<span style="color:red">* </span>: </td>
            <td colspan="2">
                <input id="oFile" type="file" runat="server" name="oFile" accept="application/pdf">
            </td>
        </tr>
        <tr>
            <td colspan="1" style="width: 25%">Folio Orden de Pago<span style="color:red">* </span>: </td>
            <td colspan="2">
                <input id="txtFolioODP" name="txtFolioODP" runat="server" type="text" placeholder="Folio de Orden de Pago"/>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Button ID="btnUpload" type="submit" Text="Guardar" runat="server" OnClick="btnUpload_Click"></asp:Button>
                <%--<input type="submit" name="submit" value="Guardar" id="submit" onclick="btnUpload_Click" disabled />--%>
                <asp:Panel ID="frmConfirmation" Visible="False" runat="server">
                    <asp:Label ID="lblUploadResult" runat="server"></asp:Label>
                    <asp:Label ID="lblBaseDatos" runat="server"></asp:Label>
                </asp:Panel>
        </tr>
    </table>
</asp:Content>
