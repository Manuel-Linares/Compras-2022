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
    public partial class Formulario_web125 : System.Web.UI.Page
    {
        int folio = 0;
        DataSet ds;
        DataTable dt;
        ClsPrincipal obj = new ClsPrincipal();

        protected void Page_Load(object sender, EventArgs e)
        {
            folio = int.Parse(Request.QueryString["folio"]);
            if (!IsPostBack)
            {
                requi();
                LlenarStatus();
            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string obstemp = "", auxRdb = "";
            MySqlConnection _conn = new MySqlConnection(Application["cnn"].ToString());

            try
            {

                /*_dsInicio = new DataSet();
                _dsInicio = _obj.IniciarSesion(txtUsuario.Text, txtContra.Text, Application["cnn"].ToString());*/
                string query = "CALL editarPartidaPendiente(" + folio + ",'" + txtComenCompras.Text + "','" + dwlEstatus.SelectedItem + "');";


                _conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, _conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (rdr[0].ToString() != "-1")
                    {
                        //Inserción exitosa
                        Response.Redirect("aspPartidasPenRRMM.aspx?msg=1");

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
                Response.Write("<script>alert('Error en BD');</script>");
            }

            _conn.Close();
        }

        public void requi()
        {
            dt = obj.DatosPartida(Application["cnn"].ToString(), folio);

            if (dt.Rows.Count > 0)
            {
                lblRequi.Text = dt.Rows[0]["Requisición"].ToString();
                lblFolio.Text = dt.Rows[0]["Folio"].ToString();
                lblDescripcion.Text = dt.Rows[0]["Descripción"].ToString();
                lblCantidad.Text = dt.Rows[0]["Cantidad"].ToString();
                lblUDeMedicion.Text = dt.Rows[0]["Medición"].ToString();
            }
        }

        public void LlenarStatus()
        {
            // Limpia los datos del data set para reinciarlo
            ds = new DataSet();
            ds = obj.ConsultaEstatus(Application["cnn"].ToString(), 4); // Ejecutara el metodo que muestra a todos los tipos de empleados
            dwlEstatus.DataSource = ds; // Asigna valores de la consulta
            dwlEstatus.DataMember = "status"; // Alias que se utilizo en la clase
            dwlEstatus.DataValueField = "id"; // Toma la propiedad de value
            dwlEstatus.DataTextField = "status";// Se visualiza y lo toma ITEM
            dwlEstatus.DataBind();// Permite que se vean los datos en el control y en la pagina web
            // Inserta un nuevo valor que no viene de la base de datos
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("aspPartidasPenRRMM.aspx?msg=0");
        }
    }
}