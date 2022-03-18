using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace wsCompras_Hgo
{
    public partial class Formulario_web110 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(string.Empty) || txtRFC.Text.Equals(string.Empty))
            {
                ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Faltan datos, Nombre y RFC son requerimientos mínimos');", true);
            }
            else
            {
                MySqlConnection _conn = new MySqlConnection(Application["cnn"].ToString());
                bool ban = false;
                string auxTipo = "", auxCurp = "", auxDirec = "", auxContac = "", auxCorreo = "";
                int auxTelef = 0;

                if (txtTipo.Text.Equals(string.Empty))
                {
                    auxTipo = ".";
                }
                else
                {
                    auxTipo = txtTipo.Text;
                }

                if (txtCURP.Text.Equals(string.Empty))
                {
                    auxCurp = ".";
                }
                else
                {
                    auxCurp = txtCURP.Text;
                }

                if (txtDireccion.Text.Equals(string.Empty))
                {
                    auxDirec = ".";
                }
                else
                {
                    auxDirec = txtDireccion.Text;
                }

                if (txtContacto.Text.Equals(string.Empty))
                {
                    auxContac = ".";
                }
                else
                {
                    auxContac = txtTipo.Text;
                }

                if (txtTelefono.Text.Equals(string.Empty))
                {
                    auxTelef = 0;
                }
                else
                {
                    auxTelef = int.Parse(txtTelefono.Text);
                }

                if (txtEmail.Text.Equals(string.Empty))
                {
                    auxCorreo = ".";
                }
                else
                {
                    auxCorreo = txtEmail.Text;
                }

                try
                {
                    /*_dsInicio = new DataSet();
                    _dsInicio = _obj.IniciarSesion(txtUsuario.Text, txtContra.Text, Application["cnn"].ToString());*/
                    string query = "CALL guardarProveedor('" + txtNombre.Text + "', '" + auxTipo + "', '" +
                                    txtRFC.Text + "', '" + auxCurp + "', '" + auxDirec + "', '" + auxContac +
                                    "', " + auxTelef + ", '" + auxCorreo + "');";


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
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("aspODCompra.aspx");
        }
    }
}