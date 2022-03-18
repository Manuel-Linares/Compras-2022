using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsCompras_Hgo
{
    public partial class Formulario_web19 : System.Web.UI.Page
    {
        ClsPrincipal _obj = new ClsPrincipal();
        DataSet _dsRequi;// Data set local a la pagina
        DataTable _dtCompra;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarProveedor(dwlProveedor);
                LlenarPartida(DropDownList1);
                LlenarPartida(DropDownList2);
                LlenarPartida(DropDownList3);
                LlenarPartida(DropDownList4);
                LlenarPartida(DropDownList5);
                LlenarPartida(DropDownList6);
                LlenarPartida(DropDownList7);
                LlenarPartida(DropDownList8);
                LlenarPartida(DropDownList9);
                LlenarPartida(DropDownList10);
                LlenarArea(dwlArea);
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtFecha.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Calendar1.Visible = true;
        }

        // Boton guardar
        protected void Button1_Click(object sender, EventArgs e)
        {
            //if (g.Empty))
            //{
            //    ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Faltan datos');", true);
            //}
            //else
            //{
                MySqlConnection _conn = new MySqlConnection(Application["cnn"].ToString());

                try
                {
                    /*_dsInicio = new DataSet();
                    _dsInicio = _obj.IniciarSesion(txtUsuario.Text, txtContra.Text, Application["cnn"].ToString());*/
                    string query = "CALL guardarODC('" + dwlProveedor.SelectedItem.Text + "', '" + txtRFC.Text + "', " + txtTelefono.Text +
                        ", '" + txtEmail.Text + "', '" + txtContacto.Text + "', '" + txtDomicilio.Text + "', '" + dwlConsignar.SelectedItem.Text +
                        "', '" + dwlEntregar.SelectedItem.Text + "', '" + txtFecha.Text + "', '" + dwlCentroCostos.SelectedItem.Text + "', '" +
                        txtCondiciones.Text + "', '" + txtObservaciones.Text + "', " + dwlArea.SelectedValue.ToString() + ", " + txtRequi1.Text + ", " +
                        txtCodigo1.Text + ", '" + txtDescripcion1.Text + "', '" + txtUnidad1.Text + "', " + txtCantidad1.Text + ", " +
                        txtPrecio1.Text + ", " + txtRequi2.Text + ", " +
                        txtCodigo2.Text + ", '" + txtDescripcion2.Text + "', '" + txtUnidad2.Text + "', " + txtCantidad2.Text + ", " +
                        txtPrecio2.Text + ", " + txtRequi3.Text + ", " +
                        txtCodigo3.Text + ", '" + txtDescripcion3.Text + "', '" + txtUnidad3.Text + "', " + txtCantidad3.Text + ", " +
                        txtPrecio3.Text + ", " + txtRequi4.Text + ", " +
                        txtCodigo4.Text + ", '" + txtDescripcion4.Text + "', '" + txtUnidad4.Text + "', " + txtCantidad4.Text + ", " +
                        txtPrecio4.Text + ", " + txtRequi5.Text + ", " +
                        txtCodigo5.Text + ", '" + txtDescripcion5.Text + "', '" + txtUnidad5.Text + "', " + txtCantidad5.Text + ", " +
                        txtPrecio5.Text + ", " + txtRequi6.Text + ", " +
                        txtCodigo6.Text + ", '" + txtDescripcion6.Text + "', '" + txtUnidad6.Text + "', " + txtCantidad6.Text + ", " +
                        txtPrecio6.Text + ", " + txtRequi7.Text + ", " +
                        txtCodigo7.Text + ", '" + txtDescripcion7.Text + "', '" + txtUnidad7.Text + "', " + txtCantidad7.Text + ", " +
                        txtPrecio7.Text + ", " + txtRequi8.Text + ", " +
                        txtCodigo8.Text + ", '" + txtDescripcion8.Text + "', '" + txtUnidad8.Text + "', " + txtCantidad8.Text + ", " +
                        txtPrecio8.Text + ", " + txtRequi9.Text + ", " +
                        txtCodigo9.Text + ", '" + txtDescripcion9.Text + "', '" + txtUnidad9.Text + "', " + txtCantidad9.Text + ", " +
                        txtPrecio9.Text + ", " + txtRequi10.Text + ", " +
                        txtCodigo10.Text + ", '" + txtDescripcion10.Text + "', '" + txtUnidad10.Text + "', " + txtCantidad10.Text + ", " +
                        txtPrecio10.Text + ");";


                    _conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, _conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        if (rdr[0].ToString() == "1")
                        {
                            // Inserción exitosa
                            ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Registro guardado');", true);
                            Response.Redirect("aspIndex.aspx");
                        }
                        else
                        {
                            // Error
                            ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('No se pudo registrar');", true);
                        }
                    }

                    rdr.Close();
                }
                catch (Exception ex)
                {
                    ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Error en BD');", true);
                }

                _conn.Close();
            //}
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        public void LlenarPartida(DropDownList dwl)
        {
            _dsRequi = new DataSet();
            _dsRequi = _obj.ConsultaPartidas(Application["cnn"].ToString()); // Ejecutara el metodo que muestra a todos los tipos de empleados
            dwl.DataSource = _dsRequi; // Asigna valores de la consulta
            dwl.DataMember = "detalles"; // Alias que se utilizo en la clase
            dwl.DataValueField = "folio"; // Toma la propiedad de value
            dwl.DataTextField = "folio";// Se visualiza y lo toma ITEM
            dwl.DataBind();// Permite que se vean los datos en el control y en la pagina web
            // Inserta un nuevo valor que no viene de la base de datos
            dwl.Items.Insert(0, "--Selecciona opción--");
        }

        public void LlenarProveedor(DropDownList dwl)
        {
            _dsRequi = new DataSet();
            _dsRequi = _obj.ConsultaProveedores(Application["cnn"].ToString()); // Ejecutara el metodo que muestra a todos los tipos de empleados
            dwl.DataSource = _dsRequi; // Asigna valores de la consulta
            dwl.DataMember = "proveedores"; // Alias que se utilizo en la clase
            dwl.DataValueField = "id"; // Toma la propiedad de value
            dwl.DataTextField = "nombre";// Se visualiza y lo toma ITEM
            dwl.DataBind();// Permite que se vean los datos en el control y en la pagina web
            // Inserta un nuevo valor que no viene de la base de datos 
            dwl.Items.Insert(0, "--Selecciona opción--");
        }

        public void LlenarDetalles(int folio, TextBox requi, TextBox desc, TextBox unidad, TextBox cantidad, TextBox precio)
        {
            _dtCompra = _obj.ConsultaDetalles(Application["cnn"].ToString(), folio);

            if (_dtCompra.Rows.Count > 0)
            {
                requi.Text = _dtCompra.Rows[0]["foliorequi"].ToString();
                desc.Text = _dtCompra.Rows[0]["descripcion"].ToString();
                unidad.Text = _dtCompra.Rows[0]["medicion"].ToString();
                cantidad.Text = _dtCompra.Rows[0]["cantidad"].ToString();
                precio.Text = _dtCompra.Rows[0]["preciounitario"].ToString();
            }
        }

        public void LlenarArea(DropDownList dwl)
        {
            _dsRequi = new DataSet();
            _dsRequi = _obj.ConsultaAreas(Application["cnn"].ToString()); // Ejecutara el metodo que muestra a todos los tipos de empleados
            dwl.DataSource = _dsRequi; // Asigna valores de la consulta 
            dwl.DataMember = "area"; // Alias que se utilizo en la clase
            dwl.DataValueField = "id"; // Toma la propiedad de value
            dwl.DataTextField = "area";// Se visualiza y lo toma ITEM
            dwl.DataBind();// Permite que se vean los datos en el control y en la pagina web
            // Inserta un nuevo valor que no viene de la base de datos 
            dwl.Items.Insert(0, "--Selecciona opción--");
        }

        public void LlenarCuenta(int id)
        {
            // Limpia los datos del data set para reinciarlo
            _dsRequi = new DataSet();
            _dsRequi = _obj.ConsultaCuentas(Application["cnn"].ToString(), id); // Ejecutara el metodo que muestra a todos los tipos de empleados
            dwlCentroCostos.DataSource = _dsRequi; // Asigna valores de la consulta 
            dwlCentroCostos.DataMember = "cuentas"; // Alias que se utilizo en la clase
            dwlCentroCostos.DataValueField = "id"; // Toma la propiedad de value
            dwlCentroCostos.DataTextField = "cuenta";// Se visualiza y lo toma ITEM
            dwlCentroCostos.DataBind();// Permite que se vean los datos en el control y en la pagina web
            // Inserta un nuevo valor que no viene de la base de datos 
            dwlCentroCostos.Items.Insert(0, "--Seleccione una opción--");
        }

        public void DetallesProveedor(int id)
        {
            _dtCompra = _obj.DatosProveedores(Application["cnn"].ToString(), id);

            if (_dtCompra.Rows.Count > 0)
            {
                txtDomicilio.Text = _dtCompra.Rows[0]["DIRECCION"].ToString();
                txtRFC.Text = _dtCompra.Rows[0]["RFC"].ToString();
                txtTelefono.Text = _dtCompra.Rows[0]["TELEFONO"].ToString();
                txtContacto.Text = _dtCompra.Rows[0]["CONTACTO"].ToString();
                txtEmail.Text = _dtCompra.Rows[0]["EMAIL"].ToString();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DropDownList1.SelectedIndex.Equals(0))
            {
                LlenarDetalles(int.Parse(DropDownList1.SelectedValue), txtRequi1, txtDescripcion1, txtUnidad1, txtCantidad1, txtPrecio1);
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DropDownList2.SelectedIndex.Equals(0))
            {
                LlenarDetalles(int.Parse(DropDownList2.SelectedValue), txtRequi2, txtDescripcion2, txtUnidad2, txtCantidad2, txtPrecio2);
            }
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DropDownList3.SelectedIndex.Equals(0))
            {
                LlenarDetalles(int.Parse(DropDownList3.SelectedValue), txtRequi3, txtDescripcion3, txtUnidad3, txtCantidad3, txtPrecio3);
            }
        }

        protected void dwlProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!dwlProveedor.SelectedIndex.Equals(0))
            {
                DetallesProveedor(int.Parse(dwlProveedor.SelectedValue));
            }
            else
            {
                txtDomicilio.Text = 
                txtRFC.Text = _dtCompra.Rows[0]["RFC"].ToString();
                txtTelefono.Text = _dtCompra.Rows[0]["TELEFONO"].ToString();
                txtContacto.Text = _dtCompra.Rows[0]["CONTACTO"].ToString();
                txtEmail.Text = _dtCompra.Rows[0]["EMAIL"].ToString();
            }
        }

        protected void dwlArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!dwlArea.SelectedIndex.Equals(0))
            {
                LlenarCuenta(int.Parse(dwlArea.SelectedValue));
            }
            else
            {
                dwlCentroCostos.Items.Clear();
            }
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("aspNuevoProveedor.aspx");
        }
    }
}