using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace wsCompras_Hgo.Compras
{
    public partial class Formulario_web122 : System.Web.UI.Page
    {
        int folio = 0;
        DataSet ds;
        DataTable dt;
        ClsPrincipal obj = new ClsPrincipal();

        protected void Page_Load(object sender, EventArgs e)
        {
            folio = int.Parse(Request.QueryString["id"]);
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

            if (!txtComentariosRRMM.Text.Equals(string.Empty))
            {
                obstemp = txtComentariosRRMM.Text;
            }

            try
            {
                /*_dsInicio = new DataSet();
                _dsInicio = _obj.IniciarSesion(txtUsuario.Text, txtContra.Text, Application["cnn"].ToString());*/
                string query = "CALL editarODC(" + folio + ",'" + obstemp + "','" + dwlEstatus.SelectedItem + "');";


                _conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, _conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (rdr[0].ToString() != "-1")
                    {
                        //Inserción exitosa
                        Response.Redirect("aspInicioCompras.aspx?msg=2");

                    }
                    else
                    {
                        // Error
                        ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('No se pudo actualizar');", true);
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

        public void requi()
        {
            dt = obj.DatosODC(Application["cnn"].ToString(), folio);

            if (dt.Rows.Count > 0)
            {
                lblFolio.Text = dt.Rows[0]["FOLIO"].ToString();
                lblFechaCreacion.Text = dt.Rows[0]["FECHA CREACION"].ToString();
                lblProveedor.Text = dt.Rows[0]["PROVEEDOR"].ToString();
                lblContacto.Text = dt.Rows[0]["CONTACTO"].ToString();
                lblConsignar.Text = dt.Rows[0]["CONSIGNAR A"].ToString();
                lblFechaEmbarque.Text = dt.Rows[0]["FECHA EMBARQUE"].ToString();
                lblArea.Text = dt.Rows[0]["ÁREA"].ToString();
                lblCentroCostos.Text = dt.Rows[0]["CENTRO DE COSTOS"].ToString();
                lblObservaciones.Text = dt.Rows[0]["OBSERVACIONES"].ToString();
            }
        }

        public void detalles()
        {
            ds = new DataSet();
            ds = obj.listarDetallesODC(Application["cnn"].ToString(), folio);
            if (ds.Tables.Count > 0)
            {
                grdPart.DataSource = ds;
                grdPart.DataMember = "DETALLESODC";
                grdPart.DataBind();
            }
        }


        public void LlenarStatus()
        {
            // Limpia los datos del data set para reinciarlo
            ds = new DataSet();
            ds = obj.ConsultaEstatus(Application["cnn"].ToString(), 6); // Ejecutara el metodo que muestra a todos los tipos de empleados
            dwlEstatus.DataSource = ds; // Asigna valores de la consulta
            dwlEstatus.DataMember = "status"; // Alias que se utilizo en la clase
            dwlEstatus.DataValueField = "id"; // Toma la propiedad de value
            dwlEstatus.DataTextField = "status";// Se visualiza y lo toma ITEM
            dwlEstatus.DataBind();// Permite que se vean los datos en el control y en la pagina web
            // Inserta un nuevo valor que no viene de la base de datos
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("aspODCRevisionCom.aspx");
        }
    }
}