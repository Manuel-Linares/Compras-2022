<%@ Page Title="" Language="C#" MasterPageFile="~/Sistemas/maestra_Sistemas.Master" AutoEventWireup="true" CodeBehind="aspNuevaRequiSis.aspx.cs" Inherits="wsCompras_Hgo.Sistemas.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width:100%;" id="main">
        <tr>
            <th colspan="5" style="text-align:left;"><h1>Nueva Requisición</h1></th>
        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Proyecto:<span style="color:red">*</span> </td>
            <td colspan="3" style="text-align:left">
                <asp:DropDownList ID="dwlProyecto" AutoPostBack="true" runat="server" Width="50%" OnSelectedIndexChanged="dwlProyecto_SelectedIndexChanged"></asp:DropDownList></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Área:<span style="color:red">*</span></td>
            <td colspan="3" style="text-align:left">
                <asp:DropDownList ID="dwlArea" AutoPostBack="true" runat="server" Width="50%" OnSelectedIndexChanged="dwlArea_SelectedIndexChanged"></asp:DropDownList></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Cuenta:<span style="color:red">*</span></td>
            <td colspan="3" style="text-align:left">
                <asp:DropDownList ID="dwlCuenta" AutoPostBack="true" runat="server" Width="50%"></asp:DropDownList></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Necesidad del bien/servicio:<span style="color:red">*</span></td>
            <td colspan="3" style="text-align:left">
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Imagenes/calendario.png" Width="25px" Height="25px" OnClick="ImageButton1_Click" />
        <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" Visible="False"></asp:Calendar>
        </td>

        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Presupuesto disponible:<span style="color:red">*</span></td>
            <td colspan="3" style="text-align:left">
                <asp:TextBox ID="txtPresupuesto" runat="server" Width="50%" TextMode="Number"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Costo aproximado:<span style="color:red">*</span></td>
            <td colspan="3" style="text-align:left">
                <asp:TextBox ID="txtCosto" runat="server" Width="50%" TextMode="Number"></asp:TextBox></td>
        </tr>
       <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Prioridad:<span style="color:red">*</span></td>
            <td colspan="3" style="text-align:left">
                <asp:DropDownList ID="dwlPrioridad" AutoPostBack="true" runat="server" Width="50%"></asp:DropDownList></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">CAUS origen: </td>
            <td colspan="3" style="text-align:left">
                <asp:TextBox ID="txtCAUS" runat="server" Width="50%"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family:Arial; width:20%">Observaciones:<span style="color:red">*</span></td>
            <td colspan="3" style="text-align:left">
                <asp:TextBox ID="txtObservaciones" runat="server" Width="50%" TextMode="MultiLine"></asp:TextBox></td>
        </tr>
        </table>
    <table style="width:100%;" id="main2">
        <tr id="detalle">
            <td colspan="5">Detalle</td>
        </tr>
        <tr id="titulo">
            <td>Descripción</td>
            <td style="width:50px">Cantidad</td>
            <td style="width:100px">Unidad de Medición</td>
            <td style="width:100px">Reembolso/Servicio</td>
            <td style="width:50px">Estatus</td>
        </tr>
        <tr>
            <td><asp:TextBox ID="Descripcion1" runat="server" Width="95%"></asp:TextBox></td>
            <td><asp:TextBox ID="Cantidad1" runat="server" Width="70%"></asp:TextBox></td>
            <td><asp:DropDownList ID="dwlUnidad1" runat="server"></asp:DropDownList></td>
            <td><asp:DropDownList ID="reembolso1" runat="server">
                <asp:ListItem Value="No">No</asp:ListItem>
                <asp:ListItem Value="Si">Si</asp:ListItem>
                </asp:DropDownList></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td><asp:TextBox ID="Descripcion2" runat="server" Width="95%"></asp:TextBox></td>
            <td><asp:TextBox ID="Cantidad2" runat="server" Width="70%"></asp:TextBox></td>
            <td><asp:DropDownList ID="dwlUnidad2" runat="server"></asp:DropDownList></td>
            <td><asp:DropDownList ID="reembolso2" runat="server">
                <asp:ListItem Value="No">No</asp:ListItem>
                <asp:ListItem Value="Si">Si</asp:ListItem>
                </asp:DropDownList></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td><asp:TextBox ID="Descripcion3" runat="server" Width="95%"></asp:TextBox></td>
            <td><asp:TextBox ID="Cantidad3" runat="server" Width="70%"></asp:TextBox></td>
            <td><asp:DropDownList ID="dwlUnidad3" runat="server"></asp:DropDownList></td>
            <td><asp:DropDownList ID="reembolso3" runat="server">
                <asp:ListItem Value="No">No</asp:ListItem>
                <asp:ListItem Value="Si">Si</asp:ListItem>
                </asp:DropDownList></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td><asp:TextBox ID="Descripcion4" runat="server" Width="95%"></asp:TextBox></td>
            <td><asp:TextBox ID="Cantidad4" runat="server" Width="70%"></asp:TextBox></td>
            <td><asp:DropDownList ID="dwlUnidad4" runat="server"></asp:DropDownList></td>
            <td><asp:DropDownList ID="reembolso4" runat="server">
                <asp:ListItem Value="No">No</asp:ListItem>
                <asp:ListItem Value="Si">Si</asp:ListItem>
                </asp:DropDownList></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td><asp:TextBox ID="Descripcion5" runat="server" Width="95%"></asp:TextBox></td>
            <td><asp:TextBox ID="Cantidad5" runat="server" Width="70%"></asp:TextBox></td>
            <td><asp:DropDownList ID="dwlUnidad5" runat="server"></asp:DropDownList></td>
            <td><asp:DropDownList ID="reembolso5" runat="server">
                <asp:ListItem Value="No">No</asp:ListItem>
                <asp:ListItem Value="Si">Si</asp:ListItem>
                </asp:DropDownList></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td><asp:TextBox ID="Descripcion6" runat="server" Width="95%"></asp:TextBox></td>
            <td><asp:TextBox ID="Cantidad6" runat="server" Width="70%"></asp:TextBox></td>
            <td><asp:DropDownList ID="dwlUnidad6" runat="server"></asp:DropDownList></td>
            <td><asp:DropDownList ID="reembolso6" runat="server">
                <asp:ListItem Value="No">No</asp:ListItem>
                <asp:ListItem Value="Si">Si</asp:ListItem>
                </asp:DropDownList></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td><asp:TextBox ID="Descripcion7" runat="server" Width="95%"></asp:TextBox></td>
            <td><asp:TextBox ID="Cantidad7" runat="server" Width="70%"></asp:TextBox></td>
            <td><asp:DropDownList ID="dwlUnidad7" runat="server"></asp:DropDownList></td>
            <td><asp:DropDownList ID="reembolso7" runat="server">
                <asp:ListItem Value="No">No</asp:ListItem>
                <asp:ListItem Value="Si">Si</asp:ListItem>
                </asp:DropDownList></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td><asp:TextBox ID="Descripcion8" runat="server" Width="95%"></asp:TextBox></td>
            <td><asp:TextBox ID="Cantidad8" runat="server" Width="70%"></asp:TextBox></td>
            <td><asp:DropDownList ID="dwlUnidad8" runat="server"></asp:DropDownList></td>
            <td><asp:DropDownList ID="reembolso8" runat="server">
                <asp:ListItem Value="No">No</asp:ListItem>
                <asp:ListItem Value="Si">Si</asp:ListItem>
                </asp:DropDownList></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td><asp:TextBox ID="Descripcion9" runat="server" Width="95%"></asp:TextBox></td>
            <td><asp:TextBox ID="Cantidad9" runat="server" Width="70%"></asp:TextBox></td>
            <td><asp:DropDownList ID="dwlUnidad9" runat="server"></asp:DropDownList></td>
            <td><asp:DropDownList ID="reembolso9" runat="server">
                <asp:ListItem Value="No">No</asp:ListItem>
                <asp:ListItem Value="Si">Si</asp:ListItem>
                </asp:DropDownList></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td><asp:TextBox ID="Descripcion10" runat="server" Width="95%"></asp:TextBox></td>
            <td><asp:TextBox ID="Cantidad10" runat="server" Width="70%"></asp:TextBox></td>
            <td><asp:DropDownList ID="dwlUnidad10" runat="server"></asp:DropDownList></td>
            <td><asp:DropDownList ID="reembolso10" runat="server">
                <asp:ListItem Value="No">No</asp:ListItem>
                <asp:ListItem Value="Si">Si</asp:ListItem>
                </asp:DropDownList></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="5" style="text-align:center">
                <asp:Button ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" /> &nbsp&nbsp&nbsp&nbsp
                <asp:Button ID="Button2" runat="server" Text="Cancelar" /></td>
        </tr>
    </table>
</asp:Content>
