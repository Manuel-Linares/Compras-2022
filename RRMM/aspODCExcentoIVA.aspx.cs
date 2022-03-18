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
    public partial class Formulario_web118 : System.Web.UI.Page
    {
        DataSet ds;
        DataTable dt;
        ClsPrincipal obj = new ClsPrincipal();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarODC();
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            lblMensaje.Visible = false;
            Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenWindow", "window.open('https://controlsit.mx/comprasv2/formatorequi/odcexentoiva.php?id=" + dwlODC.SelectedItem + "','_blank');", true);
        }

        public void LlenarODC()
        {
            // Limpia los datos del data set para reinciarlo
            ds = new DataSet();
            ds = obj.ConsultaODC(Application["cnn"].ToString()); // Ejecutara el metodo que muestra a todos los tipos de empleados
            dwlODC.DataSource = ds; // Asigna valores de la consulta
            dwlODC.DataMember = "odecompra"; // Alias que se utilizo en la clase
            dwlODC.DataValueField = "id"; // Toma la propiedad de value
            dwlODC.DataTextField = "id";// Se visualiza y lo toma ITEM
            dwlODC.DataBind();// Permite que se vean los datos en el control y en la pagina web
            // Inserta un nuevo valor que no viene de la base de datos
        }
    }
}