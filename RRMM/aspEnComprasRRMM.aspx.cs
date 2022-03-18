using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsCompras_Hgo.RRMM
{
    public partial class Formulario_web12 : System.Web.UI.Page
    {
        DataSet ds;
        ClsPrincipal obj = new ClsPrincipal();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                requisiciones();
            }
        }

        void requisiciones()
        {
            int cont = 0;
            ds = new DataSet();
            ds = obj.listarComprasUsuario(Application["cnn"].ToString(), int.Parse(Session["idUsuario"].ToString()));

            lblRequis.Visible = false;
            grdRequi.DataSource = ds;
            grdRequi.DataMember = "COMPRASU";
            grdRequi.DataBind();
            foreach (GridViewRow gr in grdRequi.Rows)
            {
                HyperLink hp = new HyperLink();
                hp.Text = gr.Cells[0].Text;
                hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatorequi/requiformato.php?folio=" + hp.Text;
                hp.Target = "_blank";
                gr.Cells[0].Controls.Add(hp);
                cont++;
            }
            if (cont > 0)
            {
                lblRequis.Visible = true;
                lblRequis.Text = "No. de requisiciones: " + cont;
            }
            else
            {
                lblRequis.Visible = true;
                lblRequis.Text = "No se han realizado requisiciones";
            }
        }
    }
}