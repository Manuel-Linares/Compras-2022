using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsCompras_Hgo.Sistemas
{
    public partial class Formulario_web14 : System.Web.UI.Page
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
            ds = new DataSet();
            ds = obj.listarRequiRev(Application["cnn"].ToString(), int.Parse(Session["idUsuario"].ToString()));
            if (ds.Tables.Count > 0)
            {
                grdRequi.DataSource = ds;
                grdRequi.DataMember = "REQUIREV";
                grdRequi.DataBind();
                foreach (GridViewRow gr in grdRequi.Rows)
                {
                    HyperLink hp = new HyperLink();
                    hp.Text = gr.Cells[0].Text;
                    hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatorequi/requiformato.php?folio=" + hp.Text;
                    hp.Target = "_blank";
                    gr.Cells[0].Controls.Add(hp);
                }
            }
            else
            {
                lblRequis.Text = "Todavia no se ha realizado ninguna requisición";
            }
        }

        protected void grdRequi_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdRequi.PageIndex = e.NewPageIndex;
            requisiciones();
        }
    }
}