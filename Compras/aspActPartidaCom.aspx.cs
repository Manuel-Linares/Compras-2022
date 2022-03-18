using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsCompras_Hgo.Compras
{
    public partial class Formulario_web19 : System.Web.UI.Page
    {
        DataSet ds;
        ClsPrincipal obj = new ClsPrincipal();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["msg"].Equals("1"))
                {
                    ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Partida editada correctamente');", true);
                }
            }
        }

        void requisiciones()
        {
            int cont = 0;
            ds = new DataSet();
            ds = obj.listarPartidasCompras(Application["cnn"].ToString(), int.Parse(txtRequi.Text));

            lblRequis.Visible = false;
            grdRequi.DataSource = ds;
            grdRequi.DataMember = "PARTIDAS_PENDIENTES";
            grdRequi.DataBind();
            foreach (GridViewRow gr in grdRequi.Rows)
            {
                cont++;
            }

            if (cont > 0)
            {
                lblRequis.ForeColor = System.Drawing.Color.DimGray;
                lblRequis.Visible = true;
                lblRequis.Text = "No. de partidas: " + cont;
            }
            else
            {
                lblRequis.ForeColor = System.Drawing.Color.Red;
                lblRequis.Visible = true;
                lblRequis.Text = "No hay partidas pendientes";
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if(!txtRequi.Text.Equals(string.Empty))
            {
                requisiciones();
            }
            else
            {
                lblRequis.Visible = true;
                lblRequis.ForeColor = System.Drawing.Color.Red;
                lblRequis.Text = "Introduce un número de requisición";
            }
        }
    }
}