using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsCompras_Hgo
{
    public partial class Formulario_web113 : System.Web.UI.Page
    {
        DataSet ds;
        ClsPrincipal obj = new ClsPrincipal();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                partidas();
            }
        }

        void partidas()
        {
            ds = new DataSet();
            ds = obj.listarActPartidas(Application["cnn"].ToString(), int.Parse(Session["idUsuario"].ToString()));
            if (ds.Tables.Count > 0)
            {
                grdPartidas.DataSource = ds;
                grdPartidas.DataMember = "REQUIS_FINALIZADAS";
                grdPartidas.DataBind();
            }
            else
            {
                lblRequis.Text = "Todavia no se ha realizado ninguna requisición";
            }
        }

        protected void grdPartidas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdPartidas.PageIndex = e.NewPageIndex;
            partidas();
        }
    }
}