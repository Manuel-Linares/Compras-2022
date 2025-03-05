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
    public partial class Formulario_web124 : System.Web.UI.Page
    {
        int id = 0;
        DataSet ds;
        DataTable dt;
        ClsPrincipal obj = new ClsPrincipal();

        protected void Page_Load(object sender, EventArgs e)
        {
            id = int.Parse(Request.QueryString["id"]);
            if (!IsPostBack)
            {
                DetallesProveedor(id);
            }
        }

        void Page_PreInit(object sender, EventArgs e)
        {
            MasterPageFile = Session["master"].ToString();
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
                string auxTipo = "", auxCurp = "", auxDirec = "", auxContac = "", auxCorreo = "", auxTelef = "";

                //if (txtTipo.Text.Equals(string.Empty))
                //{
                //    auxTipo = ".";
                //}
                //else
                //{
                //    auxTipo = txtTipo.Text;
                //}

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
                    auxContac = txtContacto.Text;
                }

                if (txtTelefono.Text.Equals(string.Empty))
                {
                    auxTelef = ".";
                }
                else
                {
                    auxTelef = txtTelefono.Text;
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
                    string query = "CALL actualizarProveedor("+id+",'" + txtNombre.Text + "', '" + auxTipo + "', '" +
                                    txtRFC.Text + "', '" + auxCurp + "', '" + auxDirec + "', '" + auxContac +
                                    "', '" + auxTelef + "', '" + auxCorreo + "');";


                    _conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, _conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        if (rdr[0].ToString() == "1")
                        {
                            // Inserción exitosa
                            ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Registro Actualizado');", true);
                            Response.Redirect("aspABCProveedor.aspx");
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
            Response.Redirect("aspABCProveedor.aspx");
        }

        public void DetallesProveedor(int id)
        {
            dt = obj.DatosProveedores(Application["cnn"].ToString(), id);

            if (dt.Rows.Count > 0)
            {
                txtNombre.Text = dt.Rows[0]["NOMBRE"].ToString();
                txtDireccion.Text = dt.Rows[0]["DIRECCION"].ToString();
                txtRFC.Text = dt.Rows[0]["RFC"].ToString();
                txtTelefono.Text = dt.Rows[0]["TELEFONO"].ToString();
                txtContacto.Text = dt.Rows[0]["CONTACTO"].ToString();
                txtEmail.Text = dt.Rows[0]["EMAIL"].ToString();
                txtCURP.Text = dt.Rows[0]["CURP"].ToString();
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string confirmValue = Request.Form["confirm_closingValue"];
            if (confirmValue == "Si")
            {

                MySqlConnection _conn = new MySqlConnection(Application["cnn"].ToString());
                string queryElim = "CALL eliminarProveedor(" + id + ");";
                try
                {
                    _conn.Open();
                    MySqlCommand cmd = new MySqlCommand(queryElim, _conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        if (rdr[0].ToString() == "1")
                        {
                            // Inserción exitosa
                            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Proveedor eliminado')", true);
                            Response.Redirect("aspABCProveedor.aspx");
                        }
                        else
                        {
                            // Error
                            ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('No se pudo eliminar');", true);
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
    }
}