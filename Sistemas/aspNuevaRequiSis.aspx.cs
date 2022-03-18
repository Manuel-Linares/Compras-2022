using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace wsCompras_Hgo.Sistemas
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {

        ClsPrincipal _obj = new ClsPrincipal();
        DataSet _dsRequi;// Data set local a la pagina
        int cant1;
        int cant2;
        int cant3;
        int cant4;
        int cant5;
        int cant6;
        int cant7;
        int cant8;
        int cant9;
        int cant10;
        string desc1;
        string desc2;
        string desc3;
        string desc4;
        string desc5;
        string desc6;
        string desc7;
        string desc8;
        string desc9;
        string desc10;
        string uni1;
        string uni2;
        string uni3;
        string uni4;
        string uni5;
        string uni6;
        string uni7;
        string uni8;
        string uni9;
        string uni10;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarProyecto();
                LlenarPrioridad();
                dwlPrioridad.SelectedIndex = 1;
                LlenarUnidad(dwlUnidad1);
                LlenarUnidad(dwlUnidad2);
                LlenarUnidad(dwlUnidad3);
                LlenarUnidad(dwlUnidad4);
                LlenarUnidad(dwlUnidad5);
                LlenarUnidad(dwlUnidad6);
                LlenarUnidad(dwlUnidad7);
                LlenarUnidad(dwlUnidad8);
                LlenarUnidad(dwlUnidad9);
                LlenarUnidad(dwlUnidad10);
            }
        }

        public void LlenarProyecto()
        {
            // Limpia los datos del data set para reinciarlo
            _dsRequi = new DataSet();
            _dsRequi = _obj.ConsultaProyectos(Application["cnn"].ToString()); // Ejecutara el metodo que muestra a todos los tipos de empleados
            dwlProyecto.DataSource = _dsRequi; // Asigna valores de la consulta
            dwlProyecto.DataMember = "proyecto"; // Alias que se utilizo en la clase
            dwlProyecto.DataValueField = "id"; // Toma la propiedad de value
            dwlProyecto.DataTextField = "proyecto";// Se visualiza y lo toma ITEM
            dwlProyecto.DataBind();// Permite que se vean los datos en el control y en la pagina web
            // Inserta un nuevo valor que no viene de la base de datos
            dwlProyecto.Items.Insert(0, "--Seleccione el proyecto--");
        }

        public void LlenarArea(int id)
        {
            // Limpia los datos del data set para reinciarlo
            _dsRequi = new DataSet();
            _dsRequi = _obj.ConsultaAreas(Application["cnn"].ToString(), id); // Ejecutara el metodo que muestra a todos los tipos de empleados
            dwlArea.DataSource = _dsRequi; // Asigna valores de la consulta 
            dwlArea.DataMember = "area"; // Alias que se utilizo en la clase
            dwlArea.DataValueField = "id"; // Toma la propiedad de value
            dwlArea.DataTextField = "area";// Se visualiza y lo toma ITEM
            dwlArea.DataBind();// Permite que se vean los datos en el control y en la pagina web
            // Inserta un nuevo valor que no viene de la base de datos 
            dwlArea.Items.Insert(0, "--Seleccione el área--");
        }

        public void LlenarCuenta(int id)
        {
            // Limpia los datos del data set para reinciarlo
            _dsRequi = new DataSet();
            _dsRequi = _obj.ConsultaCuentas(Application["cnn"].ToString(), id); // Ejecutara el metodo que muestra a todos los tipos de empleados
            dwlCuenta.DataSource = _dsRequi; // Asigna valores de la consulta 
            dwlCuenta.DataMember = "cuentas"; // Alias que se utilizo en la clase
            dwlCuenta.DataValueField = "id"; // Toma la propiedad de value
            dwlCuenta.DataTextField = "cuenta";// Se visualiza y lo toma ITEM
            dwlCuenta.DataBind();// Permite que se vean los datos en el control y en la pagina web
            // Inserta un nuevo valor que no viene de la base de datos 
            dwlCuenta.Items.Insert(0, "--Seleccione la cuenta--");
        }

        public void LlenarUnidad(DropDownList dwl)
        {
            _dsRequi = new DataSet();
            _dsRequi = _obj.ConsultaUnidades(Application["cnn"].ToString()); // Ejecutara el metodo que muestra a todos los tipos de empleados
            dwl.DataSource = _dsRequi; // Asigna valores de la consulta 
            dwl.DataMember = "unidades"; // Alias que se utilizo en la clase
            dwl.DataValueField = "id"; // Toma la propiedad de value
            dwl.DataTextField = "unidad";// Se visualiza y lo toma ITEM
            dwl.DataBind();// Permite que se vean los datos en el control y en la pagina web
            // Inserta un nuevo valor que no viene de la base de datos 
            dwl.Items.Insert(0, "--Unidad--");
        }
        public void LlenarPrioridad()
        {
            // Limpia los datos del data set para reinciarlo
            _dsRequi = new DataSet();
            _dsRequi = _obj.ConsultaPrioridad(Application["cnn"].ToString()); // Ejecutara el metodo que muestra a todos los tipos de empleados
            dwlPrioridad.DataSource = _dsRequi; // Asigna valores de la consulta
            dwlPrioridad.DataMember = "prioridad"; // Alias que se utilizo en la clase
            dwlPrioridad.DataValueField = "id"; // Toma la propiedad de value
            dwlPrioridad.DataTextField = "prioridad"; // Se visualiza y lo toma ITEM
            dwlPrioridad.DataBind(); // Permite que se vean los datos en el control y en la pagina web

            // Inserta un nuevo valor que no viene de la base de datos
        }

        protected void dwlProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!dwlProyecto.SelectedIndex.Equals(0))
            {
                LlenarArea(int.Parse(dwlProyecto.SelectedValue));
            }
        }

        protected void dwlArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!dwlArea.SelectedIndex.Equals(0))
            {
                LlenarCuenta(int.Parse(dwlArea.SelectedValue));
            }
        }

        public void validarDetalle()
        {
            if (Descripcion1.Text.Equals(string.Empty))
            {
                cant1 = 0;
                desc1 = string.Empty;
                uni1 = string.Empty;
            }
            else
            {
                cant1 = int.Parse(Cantidad1.Text);
                desc1 = Descripcion1.Text;
                uni1 = dwlUnidad1.SelectedItem.Text;
            }

            if (Descripcion2.Text.Equals(string.Empty))
            {
                cant2 = 0;
                desc2 = string.Empty;
                uni2 = string.Empty;
            }
            else
            {
                cant2 = int.Parse(Cantidad2.Text);
                desc2 = Descripcion2.Text;
                uni2 = dwlUnidad2.SelectedItem.Text;
            }

            if (Descripcion3.Text.Equals(string.Empty))
            {
                desc3 = string.Empty;
                cant3 = 0;
                uni3 = string.Empty;
            }
            else
            {
                cant3 = int.Parse(Cantidad3.Text);
                desc3 = Descripcion3.Text;
                uni3 = dwlUnidad3.SelectedItem.Text;
            }

            if (Descripcion4.Text.Equals(string.Empty))
            {
                desc4 = string.Empty;
                cant4 = 0;
                uni4 = string.Empty;
            }
            else
            {
                cant4 = int.Parse(Cantidad4.Text);
                desc4 = Descripcion4.Text;
                uni4 = dwlUnidad4.SelectedItem.Text;
            }

            if (Descripcion5.Text.Equals(string.Empty))
            {
                desc5 = string.Empty;
                cant5 = 0;
                uni5 = string.Empty;
            }
            else
            {
                cant5 = int.Parse(Cantidad5.Text);
                desc5 = Descripcion5.Text;
                uni5 = dwlUnidad5.SelectedItem.Text;
            }

            if (Descripcion6.Text.Equals(string.Empty))
            {
                desc6 = string.Empty;
                cant6 = 0;
                uni6 = string.Empty;
            }
            else
            {
                cant6 = int.Parse(Cantidad6.Text);
                desc6 = Descripcion6.Text;
                uni6 = dwlUnidad6.SelectedItem.Text;
            }

            if (Descripcion7.Text.Equals(string.Empty))
            {
                desc7 = string.Empty;
                cant7 = 0;
                uni7 = string.Empty;
            }
            else
            {
                cant7 = int.Parse(Cantidad7.Text);
                desc7 = Descripcion7.Text;
                uni7 = dwlUnidad7.SelectedItem.Text;
            }

            if (Descripcion8.Text.Equals(string.Empty))
            {
                desc8 = string.Empty;
                cant8 = 0;
                uni8 = string.Empty;
            }
            else
            {
                cant8 = int.Parse(Cantidad8.Text);
                desc8 = Descripcion8.Text;
                uni8 = dwlUnidad8.SelectedItem.Text;
            }

            if (Descripcion9.Text.Equals(string.Empty))
            {
                desc9 = string.Empty;
                cant9 = 0;
                uni9 = string.Empty;
            }
            else
            {
                cant9 = int.Parse(Cantidad9.Text);
                desc9 = Descripcion9.Text;
                uni9 = dwlUnidad9.SelectedItem.Text;
            }

            if (Descripcion10.Text.Equals(string.Empty))
            {
                desc10 = string.Empty;
                cant10 = 0;
                uni10 = string.Empty;
            }
            else
            {
                cant10 = int.Parse(Cantidad10.Text);
                desc10 = Descripcion10.Text;
                uni10 = dwlUnidad10.SelectedItem.Text;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int ult_folio = 0;
            if (dwlProyecto.SelectedIndex < 1 || dwlArea.SelectedIndex < 1 || dwlCuenta.SelectedIndex < 1 ||
                txtFecha.Text.Equals(string.Empty) || txtPresupuesto.Text.Equals(string.Empty) || txtObservaciones.Text.Equals(string.Empty))
            {
                // ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Faltan datos');", true);
                Response.Write("<script>alert('Faltan datos');</script>");
            }
            else
            {
                MySqlConnection _conn = new MySqlConnection(Application["cnn"].ToString());
                bool ban = false, bandetalle = true;
                string obser = "";
                int caus = 0;
                if (!txtCAUS.Text.Equals(string.Empty))
                {
                    caus = int.Parse(txtCAUS.Text);
                }

                if (!txtObservaciones.Text.Equals(string.Empty))
                {
                    obser = txtObservaciones.Text;
                }

                validarDetalle();

                try
                {
                    /*_dsInicio = new DataSet();
                    _dsInicio = _obj.IniciarSesion(txtUsuario.Text, txtContra.Text, Application["cnn"].ToString());*/
                    string query = "CALL guardarRequi(" + Session["idUsuario"].ToString() + ", " + dwlProyecto.SelectedValue + ", " + dwlArea.SelectedValue +
                        ", " + dwlCuenta.SelectedValue + ", '" + txtFecha.Text + "', " + txtPresupuesto.Text + ", " + txtCosto.Text + ", " + dwlPrioridad.SelectedValue +
                        ", " + caus.ToString() + ", '" + obser + "');";


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

                    try
                    {
                        string desc = "", cant = "", uni = "", reembolso = "";
                        for (int i = 0; i < 10; i++)
                        {
                            switch (i)
                            {
                                case 0:
                                    desc = desc1;
                                    cant = cant1.ToString();
                                    uni = uni1;
                                    reembolso = reembolso1.Text;
                                    break;
                                case 1:
                                    desc = desc2;
                                    cant = cant2.ToString();
                                    uni = uni2;
                                    reembolso = reembolso2.Text;
                                    break;
                                case 2:
                                    desc = desc3;
                                    cant = cant3.ToString();
                                    uni = uni3;
                                    reembolso = reembolso3.Text;
                                    break;
                                case 3:
                                    desc = desc4;
                                    cant = cant4.ToString();
                                    uni = uni4;
                                    reembolso = reembolso4.Text;
                                    break;
                                case 4:
                                    desc = desc5;
                                    cant = cant5.ToString();
                                    uni = uni5;
                                    reembolso = reembolso5.Text;
                                    break;
                                case 5:
                                    desc = desc6;
                                    cant = cant6.ToString();
                                    uni = uni6;
                                    reembolso = reembolso6.Text;
                                    break;
                                case 6:
                                    desc = desc7;
                                    cant = cant7.ToString();
                                    uni = uni7;
                                    reembolso = reembolso7.Text;
                                    break;
                                case 7:
                                    desc = desc8;
                                    cant = cant8.ToString();
                                    uni = uni8;
                                    reembolso = reembolso8.Text;
                                    break;
                                case 8:
                                    desc = desc9;
                                    cant = cant9.ToString();
                                    uni = uni9;
                                    reembolso = reembolso9.Text;
                                    break;
                                case 9:
                                    desc = desc10;
                                    cant = cant10.ToString();
                                    uni = uni10;
                                    reembolso = reembolso10.Text;
                                    break;
                            }

                            if (desc.Equals(string.Empty))
                            {
                                bandetalle = false;
                            }
                            else
                            {
                                bandetalle = true;
                            }

                            if (bandetalle)
                            {
                                string query2 = "CALL insertaDetalle(" + ult_folio + ",'" + desc + "', " + cant + ", '" + uni + "', '" + reembolso + "');";

                                cmd = new MySqlCommand(query2, _conn);
                                cmd.ExecuteNonQuery();
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                        //ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Error en BD, detalles');", true);
                        Response.Write("<script>alert('Error en BD; detalles');</script>");
                    }
                }
                catch (Exception ex)
                {
                    //ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Error en BD');", true);
                    Response.Write("<script>alert('Error en BD');</script>");
                }

                _conn.Close();

                // ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Registro guardado');", true);
                Response.Redirect("aspInicioSistemas.aspx?msg=1");
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtFecha.Text = Calendar1.SelectedDate.ToString("yyyy-MM-dd HH:mm:ss");
            Calendar1.Visible = false;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Calendar1.Visible = true;
        }


    }
}