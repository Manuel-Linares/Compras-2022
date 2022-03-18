using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace wsCompras_Hgo.RRMM
{
    public partial class Formulario_web115 : System.Web.UI.Page
    {
        ClsPrincipal _obj = new ClsPrincipal();
        DataSet _dsRequi;// Data set local a la pagina
        DataTable _dtCompra;
        string cod1, cod2, cod3, cod4, cod5, cod6, cod7, cod8, cod9, cod10;
        string desc1, desc2, desc3, desc4, desc5, desc6, desc7, desc8, desc9, desc10;
        string uni1, uni2, uni3, uni4, uni5, uni6, uni7, uni8, uni9, uni10;
        int cant1, cant2, cant3, cant4, cant5, cant6, cant7, cant8, cant9, cant10;
        double prec1, prec2, prec3, prec4, prec5, prec6, prec7, prec8, prec9, prec10;
        int part1, part2, part3, part4, part5, part6, part7, part8, part9, part10;
        int req1, req2, req3, req4, req5, req6, req7, req8, req9, req10;

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
            txtFecha.Text = Calendar1.SelectedDate.ToString("yyyy-MM-dd");
            Calendar1.Visible = false;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Calendar1.Visible = true;
        }
        public void validarDetalle()
        {
            if (txtRequi1.Text.Equals(string.Empty))
            {
                cod1 = string.Empty;
                desc1 = string.Empty;
                uni1 = string.Empty;
                cant1 = 0;
                prec1 = 0;
                part1 = 0;
                req1 = 0;
            }
            else
            {
                cod1 = txtCodigo1.Text;
                desc1 = txtDescripcion1.Text;
                uni1 = txtUnidad1.Text;
                cant1 = int.Parse(txtCantidad1.Text);
                if (!txtPrecio1.Text.Equals(string.Empty))
                {
                    prec1 = double.Parse(txtPrecio1.Text);
                }
                else
                {
                    prec1 = 0;
                }
                part1 = int.Parse(DropDownList1.SelectedValue);
                req1 = int.Parse(txtRequi1.Text);
            }

            if (txtRequi2.Text.Equals(string.Empty))
            {
                cod2 = string.Empty;
                desc2 = string.Empty;
                uni2 = string.Empty;
                cant2 = 0;
                prec2 = 0;
                part2 = 0;
                req2 = 0;
            }
            else
            {
                cod2 = txtCodigo2.Text;
                desc2 = txtDescripcion2.Text;
                uni2 = txtUnidad2.Text;
                cant2 = int.Parse(txtCantidad2.Text);
                if (!txtPrecio2.Text.Equals(string.Empty))
                {
                    prec2 = double.Parse(txtPrecio2.Text);
                }
                else
                {
                    prec2 = 0;
                }

                part2 = int.Parse(DropDownList2.SelectedValue);
                req2 = int.Parse(txtRequi2.Text);
            }

            if (txtRequi3.Text.Equals(string.Empty))
            {
                cod3 = string.Empty;
                desc3 = string.Empty;
                uni3 = string.Empty;
                cant3 = 0;
                prec3 = 0;
                part3 = 0;
                req3 = 0;
            }
            else
            {
                cod3 = txtCodigo3.Text;
                desc3 = txtDescripcion3.Text;
                uni3 = txtUnidad3.Text;
                cant3 = int.Parse(txtCantidad3.Text);
                if (!txtPrecio3.Text.Equals(string.Empty))
                {
                    prec3 = double.Parse(txtPrecio3.Text);
                }
                else
                {
                    prec3 = 0;
                }
                part3 = int.Parse(DropDownList3.SelectedValue);
                req3 = int.Parse(txtRequi3.Text);
            }

            if (txtRequi4.Text.Equals(string.Empty))
            {
                cod4 = string.Empty;
                desc4 = string.Empty;
                uni4 = string.Empty;
                cant4 = 0;
                prec4 = 0;
                part4 = 0;
                req4 = 0;
            }
            else
            {
                cod4 = txtCodigo4.Text;
                desc4 = txtDescripcion4.Text;
                uni4 = txtUnidad4.Text;
                cant4 = int.Parse(txtCantidad4.Text);
                if (!txtPrecio4.Text.Equals(string.Empty))
                {
                    prec4 = double.Parse(txtPrecio4.Text);
                }
                else
                {
                    prec4 = 0;
                }
                part4 = int.Parse(DropDownList4.SelectedValue);
                req4 = int.Parse(txtRequi4.Text);
            }

            if (txtRequi5.Text.Equals(string.Empty))
            {
                cod5 = string.Empty;
                desc5 = string.Empty;
                uni5 = string.Empty;
                cant5 = 0;
                prec5 = 0;
                part5 = 0;
                req5 = 0;
            }
            else
            {
                cod5 = txtCodigo5.Text;
                desc5 = txtDescripcion5.Text;
                uni5 = txtUnidad5.Text;
                cant5 = int.Parse(txtCantidad5.Text);
                if (!txtPrecio5.Text.Equals(string.Empty))
                {
                    prec5 = double.Parse(txtPrecio5.Text);
                }
                else
                {
                    prec5 = 0;
                }
                part5 = int.Parse(DropDownList5.SelectedValue);
                req5 = int.Parse(txtRequi5.Text);
            }

            if (txtRequi6.Text.Equals(string.Empty))
            {
                cod6 = string.Empty;
                desc6 = string.Empty;
                uni6 = string.Empty;
                cant6 = 0;
                prec6 = 0;
                part6 = 0;
                req6 = 0;
            }
            else
            {
                cod6 = txtCodigo6.Text;
                desc6 = txtDescripcion6.Text;
                uni6 = txtUnidad6.Text;
                cant6 = int.Parse(txtCantidad6.Text);
                if (!txtPrecio6.Text.Equals(string.Empty))
                {
                    prec6 = double.Parse(txtPrecio6.Text);
                }
                else
                {
                    prec6 = 0;
                }
                part6 = int.Parse(DropDownList6.SelectedValue);
                req6 = int.Parse(txtRequi6.Text);
            }

            if (txtRequi7.Text.Equals(string.Empty))
            {
                cod7 = string.Empty;
                desc7 = string.Empty;
                uni7 = string.Empty;
                cant7 = 0;
                prec7 = 0;
                part7 = 0;
                req7 = 0;
            }
            else
            {
                cod7 = txtCodigo7.Text;
                desc7 = txtDescripcion7.Text;
                uni7 = txtUnidad7.Text;
                cant7 = int.Parse(txtCantidad7.Text);
                if (!txtPrecio7.Text.Equals(string.Empty))
                {
                    prec7 = double.Parse(txtPrecio7.Text);
                }
                else
                {
                    prec7 = 0;
                }
                part7 = int.Parse(DropDownList7.SelectedValue);
                req7 = int.Parse(txtRequi7.Text);
            }

            if (txtRequi8.Text.Equals(string.Empty))
            {
                cod8 = string.Empty;
                desc8 = string.Empty;
                uni8 = string.Empty;
                cant8 = 0;
                prec8 = 0;
                part8 = 0;
                req8 = 0;
            }
            else
            {
                cod8 = txtCodigo8.Text;
                desc8 = txtDescripcion8.Text;
                uni8 = txtUnidad8.Text;
                cant8 = int.Parse(txtCantidad8.Text);
                if (!txtPrecio8.Text.Equals(string.Empty))
                {
                    prec8 = double.Parse(txtPrecio8.Text);
                }
                else
                {
                    prec8 = 0;
                }
                part8 = int.Parse(DropDownList8.SelectedValue);
                req8 = int.Parse(txtRequi8.Text);
            }

            if (txtRequi9.Text.Equals(string.Empty))
            {
                cod9 = string.Empty;
                desc9 = string.Empty;
                uni9 = string.Empty;
                cant9 = 0;
                prec9 = 0;
                part9 = 0;
                req9 = 0;
            }
            else
            {
                cod9 = txtCodigo9.Text;
                desc9 = txtDescripcion9.Text;
                uni9 = txtUnidad9.Text;
                cant9 = int.Parse(txtCantidad9.Text);
                if (!txtPrecio9.Text.Equals(string.Empty))
                {
                    prec9 = double.Parse(txtPrecio9.Text);
                }
                else
                {
                    prec9 = 0;
                }
                part9 = int.Parse(DropDownList9.SelectedValue);
                req9 = int.Parse(txtRequi9.Text);
            }

            if (txtRequi10.Text.Equals(string.Empty))
            {
                cod10 = string.Empty;
                desc10 = string.Empty;
                uni10 = string.Empty;
                cant10 = 0;
                prec10 = 0;
                part10 = 0;
                req10 = 0;
            }
            else
            {
                cod10 = txtCodigo10.Text;
                desc10 = txtDescripcion10.Text;
                uni10 = txtUnidad10.Text;
                cant10 = int.Parse(txtCantidad10.Text);
                if (!txtPrecio10.Text.Equals(string.Empty))
                {
                    prec10 = double.Parse(txtPrecio10.Text);
                }
                else
                {
                    prec10 = 0;
                }
                part10 = int.Parse(DropDownList10.SelectedValue);
                req10 = int.Parse(txtRequi10.Text);
            }
        }

        // Boton guardar
        protected void Button1_Click(object sender, EventArgs e)
        {
            // if (g.Empty))
            // {
            //    ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Faltan datos');", true);
            // }
            // else
            // {
            MySqlConnection _conn = new MySqlConnection(Application["cnn"].ToString());
            int ult_folio = 0;
            string tele = "", tama1;
            bool bandetalle = true;

            try
            {
                if (txtTelefono.Text != String.Format("##########"))
                {
                    tele = "000";
                }
                else
                {
                    tele = txtTelefono.Text;
                }

                if (fluCotizacion1.HasFile)
                {
                    tama1 = fluCotizacion1.FileBytes.ToString();
                }

                /*_dsInicio = new DataSet();
                _dsInicio = _obj.IniciarSesion(txtUsuario.Text, txtContra.Text, Application["cnn"].ToString());*/
                string query = "CALL guardarODC('" + dwlProveedor.SelectedItem.Text + "', '" + txtRFC.Text + "', " + tele +
                    ", '" + txtEmail.Text + "', '" + txtContacto.Text + "', '" + txtDomicilio.Text + "', '" + dwlConsignar.SelectedItem.Text +
                    "', '" + dwlEntregar.SelectedItem.Text + "', '" + txtFecha.Text + "', '" + dwlCentroCostos.SelectedItem.Text + "', '" +
                    txtCondiciones.Text + "', '" + txtObservaciones.Text + "', " + dwlArea.SelectedValue.ToString() + ", " + Session["plaza"].ToString() + ");";


                _conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, _conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (rdr[0].ToString() != "-1")
                    {
                        // Inserción exitosa
                        // ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Registro guardado');", true);

                        // Inserción detalles
                        ult_folio = int.Parse(rdr[1].ToString());
                        bandetalle = true;
                    }
                    else
                    {
                        // Error
                        ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('No se pudo registrar');", true);
                    }
                }

                rdr.Close();

                validarDetalle();
                try
                {
                    string cod = "", descr = "", uni_medi = "", cant = "", prec_uni = "", partida_folio = "", requi_folio = "";
                    for (int i = 0; i < 10; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                cod = cod1;
                                descr = desc1;
                                uni_medi = uni1;
                                cant = cant1.ToString();
                                prec_uni = prec1.ToString();
                                partida_folio = part1.ToString();
                                requi_folio = req1.ToString();
                                break;
                            case 1:
                                cod = cod2;
                                descr = desc2;
                                uni_medi = uni2;
                                cant = cant2.ToString();
                                prec_uni = prec2.ToString();
                                partida_folio = part2.ToString();
                                requi_folio = req2.ToString();
                                break;
                            case 2:
                                cod = cod3;
                                descr = desc3;
                                uni_medi = uni3;
                                cant = cant3.ToString();
                                prec_uni = prec3.ToString();
                                partida_folio = part3.ToString();
                                requi_folio = req3.ToString();
                                break;
                            case 3:
                                cod = cod4;
                                descr = desc4;
                                uni_medi = uni4;
                                cant = cant4.ToString();
                                prec_uni = prec4.ToString();
                                partida_folio = part4.ToString();
                                requi_folio = req4.ToString();
                                break;
                            case 4:
                                cod = cod5;
                                descr = desc5;
                                uni_medi = uni5;
                                cant = cant5.ToString();
                                prec_uni = prec5.ToString();
                                partida_folio = part5.ToString();
                                requi_folio = req5.ToString();
                                break;
                            case 5:
                                cod = cod6;
                                descr = desc6;
                                uni_medi = uni6;
                                cant = cant6.ToString();
                                prec_uni = prec6.ToString();
                                partida_folio = part6.ToString();
                                requi_folio = req6.ToString();
                                break;
                            case 6:
                                cod = cod7;
                                descr = desc7;
                                uni_medi = uni7;
                                cant = cant7.ToString();
                                prec_uni = prec7.ToString();
                                partida_folio = part7.ToString();
                                requi_folio = req7.ToString();
                                break;
                            case 7:
                                cod = cod8;
                                descr = desc8;
                                uni_medi = uni8;
                                cant = cant8.ToString();
                                prec_uni = prec8.ToString();
                                partida_folio = part8.ToString();
                                requi_folio = req8.ToString();
                                break;
                            case 8:
                                cod = cod9;
                                descr = desc9;
                                uni_medi = uni9;
                                cant = cant9.ToString();
                                prec_uni = prec9.ToString();
                                partida_folio = part9.ToString();
                                requi_folio = req9.ToString();
                                break;
                            case 9:
                                cod = cod10;
                                descr = desc10;
                                uni_medi = uni10;
                                cant = cant10.ToString();
                                prec_uni = prec10.ToString();
                                partida_folio = part10.ToString();
                                requi_folio = req10.ToString();
                                break;
                        }

                        if (partida_folio == "0")
                        {
                            bandetalle = false;
                        }
                        else
                        {
                            bandetalle = true;
                        }

                        if (bandetalle)
                        {
                            string query2 = "CALL insertaDetalleODC(" + ult_folio + ",'" + cod + "', '" + descr + "', '" + uni_medi + "', " + cant + "," + prec_uni + "," + partida_folio + "," + requi_folio + ");";

                            cmd = new MySqlCommand(query2, _conn);
                            cmd.ExecuteNonQuery();
                        }

                    }
                }
                catch (Exception ex)
                {
                    ex.ToString();
                    ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Error en BD, detalles');", true);
                    Response.Write("<script>alert('Error en BD; detalles');</script>");
                }
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Error en BD');", true);
            }

            _conn.Close();
            Response.Redirect("aspInicioRRMM.aspx?msg=1");
            // }
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
            dwlCentroCostos.DataTextField = "cuenta"; // Se visualiza y lo toma ITEM
            dwlCentroCostos.DataBind(); // Permite que se vean los datos en el control y en la pagina web

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

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DropDownList4.SelectedIndex.Equals(0))
            {
                LlenarDetalles(int.Parse(DropDownList4.SelectedValue), txtRequi4, txtDescripcion4, txtUnidad4, txtCantidad4, txtPrecio4);
            }
        }

        protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DropDownList5.SelectedIndex.Equals(0))
            {
                LlenarDetalles(int.Parse(DropDownList5.SelectedValue), txtRequi5, txtDescripcion5, txtUnidad5, txtCantidad5, txtPrecio5);
            }
        }

        protected void DropDownList6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DropDownList6.SelectedIndex.Equals(0))
            {
                LlenarDetalles(int.Parse(DropDownList6.SelectedValue), txtRequi6, txtDescripcion6, txtUnidad6, txtCantidad6, txtPrecio6);
            }
        }

        protected void DropDownList7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DropDownList7.SelectedIndex.Equals(0))
            {
                LlenarDetalles(int.Parse(DropDownList7.SelectedValue), txtRequi7, txtDescripcion7, txtUnidad7, txtCantidad7, txtPrecio7);
            }
        }

        protected void DropDownList8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DropDownList8.SelectedIndex.Equals(0))
            {
                LlenarDetalles(int.Parse(DropDownList8.SelectedValue), txtRequi8, txtDescripcion8, txtUnidad8, txtCantidad8, txtPrecio8);
            }
        }

        protected void DropDownList9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DropDownList9.SelectedIndex.Equals(0))
            {
                LlenarDetalles(int.Parse(DropDownList9.SelectedValue), txtRequi9, txtDescripcion9, txtUnidad9, txtCantidad9, txtPrecio9);
            }
        }

        protected void DropDownList10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DropDownList10.SelectedIndex.Equals(0))
            {
                LlenarDetalles(int.Parse(DropDownList10.SelectedValue), txtRequi10, txtDescripcion10, txtUnidad10, txtCantidad10, txtPrecio10);
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
            Response.Redirect("aspNuevoProveedorRRMM.aspx");
        }
    }
}