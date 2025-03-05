using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace wsCompras_Hgo.Sistemas
{
    public partial class Formulario_web18 : System.Web.UI.Page
    {
        DataSet ds;
        DataTable dt;
        ClsPrincipal obj = new ClsPrincipal();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarRequi();
            }
        }

        public void LlenarRequi()
        {
            // Limpia los datos del data set para reinciarlo
            ds = new DataSet();
            ds = obj.ConsultaRequi(Application["cnn"].ToString()); // Ejecutara el metodo que muestra a todos los tipos de empleados
            dwlRequi.DataSource = ds; // Asigna valores de la consulta
            dwlRequi.DataMember = "requi"; // Alias que se utilizo en la clase
            dwlRequi.DataValueField = "FOLIO"; // Toma la propiedad de value
            dwlRequi.DataTextField = "FOLIO"; // Se visualiza y lo toma ITEM
            dwlRequi.DataBind(); // Permite que se vean los datos en el control y en la pagina web

            // Inserta un nuevo valor que no viene de la base de datos
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            string strFileName;
            string strFilePath;
            string strFolder;
            string strNombre;
            bool ban = false;

            strFolder = Server.MapPath("../ODP/");

            // Lee el nombre del archivo por subir
            strFileName = oFile.PostedFile.FileName;
            strFileName = Path.GetFileName(strFileName);

            // Valida que se haya seleccionado un archivo
            if (oFile.Value != "")
            {
                // Valida que se haya introducido un folio de OP
                if (!txtFolioODP.Value.Equals(string.Empty))
                {
                    // Crea el directorio si no existe en la ubicación relativa
                    if (!Directory.Exists(strFolder))
                    {
                        Directory.CreateDirectory(strFolder);
                    }

                    // Nombre de archivo modificado
                    strNombre="OP_" + txtFolioODP.Value + "_Req_" + dwlRequi.SelectedValue + ".pdf";

                    // Guarda el archivo en la carpeta
                    strFilePath = strFolder + strNombre;
                    if (File.Exists(strFilePath))
                    {
                        lblUploadResult.Text = "Ya existe una orden de pago para la requisición seleccionada";
                    }
                    else
                    {
                        oFile.PostedFile.SaveAs(strFilePath);
                        lblUploadResult.Text = strFileName + " se ha guardado en directorio correctamente.";

                        // Guarda registro en base de datos
                        MySqlConnection _conn = new MySqlConnection(Application["cnn"].ToString());

                        try
                        {
                            string query = "CALL guardarOrdenPago(" + txtFolioODP.Value + ", " + Session["idUsuario"] + ", " + dwlRequi.SelectedValue + ", '" + strNombre + "');";


                            _conn.Open();
                            MySqlCommand cmd = new MySqlCommand(query, _conn);
                            MySqlDataReader rdr = cmd.ExecuteReader();

                            while (rdr.Read())
                            {
                                if (rdr[0].ToString() == "1")
                                {
                                    ban = true;
                                }
                                else
                                {
                                    // Error
                                    lblBaseDatos.Text = "Ha ocurrido un error en BD";
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            lblBaseDatos.Text = ex.ToString();
                        }

                        _conn.Close();

                        if (ban)
                        {
                            Response.Redirect("aspInicioSistemas.aspx?msg=1");
                        }
                    }
                }
                else
                {
                    lblUploadResult.Text = "Debes especificar un folio de orden.";
                }
            }
            else
            {
                lblUploadResult.Text = "Selecciona un archivo para subir.";
            }

            // Display the result of the upload.
            frmConfirmation.Visible = true;
        }
    }
}