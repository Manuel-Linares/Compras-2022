<%@ Page Title="" Language="C#" MasterPageFile="~/RRMM/master_RRMM.Master" AutoEventWireup="true" CodeBehind="aspNuevaODCRRMM.aspx.cs" Inherits="wsCompras_Hgo.RRMM.Formulario_web115" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table style="width: 100%;" id="main">
        <tr>
            <th colspan="7" style="text-align: left;">
                <h1>Orden de Compra</h1>
            </th>
        </tr>
        <tr>
            <td colspan="3" style="font-family: Arial; width: 20%">Proveedor<span style="color: red">*</span> </td>
            <td colspan="4" style="text-align: left">
                <asp:DropDownList ID="dwlProveedor" AutoPostBack="true" runat="server" Width="50%" OnSelectedIndexChanged="dwlProveedor_SelectedIndexChanged"></asp:DropDownList> &nbsp;&nbsp;
                <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Imagenes/157-1576931_plus-sign-play-button-vector-png-transparent-png.png" Width="20px" AlternateText="Registrar nuevo Proveedor" OnClick="ImageButton2_Click" ToolTip="Registrar nuevo Proveedor" />
            </td>
        </tr>
        <tr>
            <td colspan="3" style="font-family: Arial; width: 20%">Domicilio</td>
            <td colspan="4" style="text-align: left">
                <asp:TextBox ID="txtDomicilio" runat="server" Width="50%"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="3" style="font-family: Arial; width: 20%">RFC</td>
            <td colspan="4" style="text-align: left">
                <asp:TextBox ID="txtRFC" runat="server" Width="50%"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="3" style="font-family: Arial; width: 20%">Telefono</td>
            <td colspan="4" style="text-align: left">
                <asp:TextBox ID="txtTelefono" runat="server" Width="50%"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="3" style="font-family: Arial; width: 20%">Contacto</td>
            <td colspan="4" style="text-align: left">
                <asp:TextBox ID="txtContacto" runat="server" Width="50%"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="3" style="font-family: Arial; width: 20%">Email</td>
            <td colspan="4" style="text-align: left">
                <asp:TextBox ID="txtEmail" runat="server" Width="50%"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="3" style="font-family: Arial; width: 20%">Consignar a </td>
            <td colspan="4" style="text-align: left">
                <asp:DropDownList ID="dwlConsignar" AutoPostBack="true" runat="server" Width="50%">
                    <asp:ListItem>CRIT Hidalgo</asp:ListItem>
                    <asp:ListItem>CRIT Veracruz</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td colspan="3" style="font-family: Arial; width: 20%">Entregar a </td>
            <td colspan="4" style="text-align: left">
                <asp:DropDownList ID="dwlEntregar" AutoPostBack="true" runat="server" Width="50%">
                    <asp:ListItem>Almacén</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td colspan="3" style="font-family: Arial; width: 20%">Fecha de embarque<span style="color: red">*</span></td>
            <td colspan="4" style="text-align: left">
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Imagenes/calendario.png" Width="25px" Height="25px" OnClick="ImageButton1_Click" />
                <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
                <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" Visible="False"></asp:Calendar>
            </td>
        </tr>
        <tr>
            <td colspan="3" style="font-family: Arial; width: 20%">Area </td>
            <td colspan="4" style="text-align: left">
                <asp:DropDownList ID="dwlArea" AutoPostBack="true" runat="server" Width="50%" OnSelectedIndexChanged="dwlArea_SelectedIndexChanged"></asp:DropDownList></td>
        </tr>
        <tr>
            <td colspan="3" style="font-family: Arial; width: 20%">Centro de Costos </td>
            <td colspan="4" style="text-align: left">
                <asp:DropDownList ID="dwlCentroCostos" AutoPostBack="true" runat="server" Width="50%"></asp:DropDownList></td>
        </tr>
        <tr>
            <td colspan="3" style="font-family: Arial; width: 20%">Condiciones de embarque </td>
            <td colspan="4" style="text-align: left">
                <asp:TextBox ID="txtCondiciones" runat="server" TextMode="MultiLine" Width="50%"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="3" style="font-family: Arial; width: 20%">Cotización 1 </td>
            <td colspan="4" style="text-align: left">
                <%--<input id="oFileCot1" type="file" runat="server" name="oFileCot1" accept="application/pdf">--%>
                <asp:FileUpload ID="oFileCot" runat="server" AllowMultiple="false" />
        </tr>
        <tr>
            <td colspan="3" style="font-family: Arial; width: 20%">Cotización 2 </td>
            <td colspan="4" style="text-align: left">
                <asp:FileUpload ID="oFileCot2" runat="server" AllowMultiple="false"/>
        </tr>
        <tr>
            <td colspan="3" style="font-family: Arial; width: 20%">Cotización 3 </td>
            <td colspan="4" style="text-align: left">
                <%--<input id="oFileCot3" type="file" runat="server" name="oFileCot3" accept="application/pdf">--%>
                <asp:FileUpload ID="oFileCot3" runat="server" AllowMultiple="false"/>
        </tr>
        <tr>
            <td colspan="3" style="font-family: Arial; width: 20%">Archivo comité </td>
            <td colspan="4" style="text-align: left">
                <%--<input id="oFileComite" type="file" runat="server" name="oFileComite" accept="application/pdf" disabled="disabled">--%>
                <asp:FileUpload ID="oFileComite" runat="server" AllowMultiple="false"/>
        </tr>
        <tr>
            <td colspan="3" style="font-family: Arial; width: 20%">Observaciones </td>
            <td colspan="4" style="text-align: left">
                <asp:TextBox ID="txtObservaciones" runat="server" TextMode="MultiLine" Width="50%"></asp:TextBox></td>
        </tr>
    </table>
    <table style="width: 100%;" id="main2">
        <tr id="detalle">
            <td colspan="7">ODC Detalle</td>
        </tr>
        <tr id="titulo">
            <td>Folio partida</td>
            <td>Requisición</td>
            <td>Código</td>
            <td>Descripción</td>
            <td>Unidad de medida</td>
            <td>Cantidad</td>
            <td>Precio Unitario</td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList></td>
            <td>
                <asp:TextBox ID="txtRequi1" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtCodigo1" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtDescripcion1" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtUnidad1" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtCantidad1" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtPrecio1" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"></asp:DropDownList></td>
            <td>
                <asp:TextBox ID="txtRequi2" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtCodigo2" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtDescripcion2" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtUnidad2" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtCantidad2" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtPrecio2" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged"></asp:DropDownList></td>
            <td>
                <asp:TextBox ID="txtRequi3" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtCodigo3" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtDescripcion3" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtUnidad3" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtCantidad3" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtPrecio3" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged"></asp:DropDownList></td>
            <td>
                <asp:TextBox ID="txtRequi4" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtCodigo4" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtDescripcion4" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtUnidad4" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtCantidad4" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtPrecio4" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="DropDownList5" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList5_SelectedIndexChanged"></asp:DropDownList></td>
            <td>
                <asp:TextBox ID="txtRequi5" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtCodigo5" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtDescripcion5" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtUnidad5" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtCantidad5" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtPrecio5" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="DropDownList6" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList6_SelectedIndexChanged"></asp:DropDownList></td>
            <td>
                <asp:TextBox ID="txtRequi6" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtCodigo6" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtDescripcion6" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtUnidad6" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtCantidad6" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtPrecio6" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="DropDownList7" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList7_SelectedIndexChanged"></asp:DropDownList></td>
            <td>
                <asp:TextBox ID="txtRequi7" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtCodigo7" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtDescripcion7" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtUnidad7" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtCantidad7" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtPrecio7" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="DropDownList8" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList8_SelectedIndexChanged"></asp:DropDownList></td>
            <td>
                <asp:TextBox ID="txtRequi8" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtCodigo8" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtDescripcion8" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtUnidad8" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtCantidad8" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtPrecio8" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="DropDownList9" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList9_SelectedIndexChanged"></asp:DropDownList></td>
            <td>
                <asp:TextBox ID="txtRequi9" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtCodigo9" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtDescripcion9" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtUnidad9" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtCantidad9" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtPrecio9" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="DropDownList10" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList10_SelectedIndexChanged"></asp:DropDownList></td>
            <td>
                <asp:TextBox ID="txtRequi10" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtCodigo10" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtDescripcion10" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtUnidad10" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtCantidad10" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtPrecio10" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="7" style="text-align: center">
                <asp:Button ID="Button5" runat="server" Text="Guardar" OnClick="Button1_Click" />
                &nbsp&nbsp&nbsp&nbsp
                <asp:Button ID="Button6" runat="server" Text="Cancelar" OnClick="Button2_Click" /></td>
        </tr>
    </table>
</asp:Content>
