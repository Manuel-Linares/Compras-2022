using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsCompras_Hgo.DM
{
    public partial class maestra_DM : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                pnl1.Visible = false;
                lnkCancelar.ForeColor = System.Drawing.Color.DarkCyan;
                lnkCerrar.ForeColor = System.Drawing.Color.DarkCyan;
            }

            if (Session["idUsuario"].Equals(0))
            {
                Response.Redirect("../aspInicio.aspx?ses=2");
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (pnl1.Visible)
            {
                pnl1.Visible = false;
            }
            else
            {
                pnl1.Visible = true;
            }

        }

        protected void lnkCancelar_Click(object sender, EventArgs e)
        {
            pnl1.Visible = false;
        }

        protected void lnkCerrar_Click(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            Session["nomUsuario"] = "";
            Session["idUsuario"] = 0;
            Session["nombre"] = "";
            Session["plaza"] = 0;
            Session["userlevel"] = 0;
            Session["area"] = 0;
            Session["subarea"] = 0;
            Response.Redirect("../aspInicio.aspx?ses=1");
        }
    }
}