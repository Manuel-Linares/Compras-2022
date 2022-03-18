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
    public partial class Formulario_web120 : System.Web.UI.Page
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
                detalles();
                LlenarStatus();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string obstemp = "";
            MySqlConnection _conn = new MySqlConnection(Application["cnn"].ToString());

            if (!txtObservacionesDG.Text.Equals(string.Empty))
            {
                obstemp = txtObservacionesDG.Text;
            }

            try
            {
                /*_dsInicio = new DataSet();
                _dsInicio = _obj.IniciarSesion(txtUsuario.Text, txtContra.Text, Application["cnn"].ToString());*/
                string query = "CALL editarRequi(" + folio + ",'" + obstemp + "','" + dwlEstatus.SelectedItem + "');";


                _conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, _conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (rdr[0].ToString() != "-1")
                    {
                        //Inserción exitosa
                        Response.Redirect("aspInicioRRMM.aspx?msg=2");

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
            dt = obj.DatosRequi(Application["cnn"].ToString(), folio);

            if (dt.Rows.Count > 0)
            {
                lblFolio.Text = dt.Rows[0]["FOLIO"].ToString();
                lblNombre.Text = dt.Rows[0]["Nombre"].ToString();
                lblCuenta.Text = dt.Rows[0]["Cuenta"].ToString();
                lblFechaCreacion.Text = dt.Rows[0]["Fecha de Creación"].ToString();
                lblFechaEstimada.Text = dt.Rows[0]["Fecha Estimada"].ToString();
                lblObservaciones.Text = dt.Rows[0]["Observaciones"].ToString();
                lblPresupuesto.Text = dt.Rows[0]["Presupuesto"].ToString();
                lblCosto.Text = dt.Rows[0]["Costo Aproximado"].ToString();
                lblPrioridad.Text = dt.Rows[0]["Prioridad"].ToString();
            }
        }

        public void detalles()
        {
            ds = new DataSet();
            ds = obj.listarDetalles(Application["cnn"].ToString(), folio);
            if (ds.Tables.Count > 0)
            {
                grdPart.DataSource = ds;
                grdPart.DataMember = "DETALLES";
                grdPart.DataBind();
            }
        }

        public void LlenarStatus()
        {
            // Limpia los datos del data set para reinciarlo
            ds = new DataSet();
            ds = obj.ConsultaEstatus(Application["cnn"].ToString(), 3); // Ejecutara el metodo que muestra a todos los tipos de empleados
            dwlEstatus.DataSource = ds; // Asigna valores de la consulta
            dwlEstatus.DataMember = "status"; // Alias que se utilizo en la clase
            dwlEstatus.DataValueField = "id"; // Toma la propiedad de value
            dwlEstatus.DataTextField = "status";// Se visualiza y lo toma ITEM
            dwlEstatus.DataBind();// Permite que se vean los datos en el control y en la pagina web
            // Inserta un nuevo valor que no viene de la base de datos
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("aspRequiRRMM.aspx");
        }
    }
}