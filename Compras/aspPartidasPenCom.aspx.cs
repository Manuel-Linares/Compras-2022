// CRIT Hidalgo. Fundación Teletón México A.C. @2021
// Creado por: Manuel Linares

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsCompras_Hgo.Compras
{
    public partial class Formulario_web110 : System.Web.UI.Page
    {
        DataSet ds;
        ClsPrincipal obj = new ClsPrincipal();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                requisiciones();
                if (Request.QueryString["msg"].Equals("1"))
                {
                    ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Partida editada correctamente');", true);
                }
            }
        }

        private DataTable BindGridView()
        {
            ds = new DataSet();
            ds = obj.listarPartPendientes(Application["cnn"].ToString());
            return ds.Tables[0];
        }

        private DataTable BindGridView2(int foliorequi, int foliopart)
        {
            ds = new DataSet();
            ds = obj.listarPartPendientes(Application["cnn"].ToString(), foliorequi, foliopart);
            return ds.Tables[0];
        }

        void requisiciones()
        {
            int cont = 0;

            lblRequis.Visible = false;
            grdRequi.DataSource = BindGridView();
            grdRequi.DataMember = "PARTIDAS_PENDIENTES";
            grdRequi.DataBind();

            foreach (GridViewRow gr in grdRequi.Rows)
            {
                //HyperLink hp = new HyperLink();
                //hp.Text = gr.Cells[1].Text;
                //hp.Target = "blank_";
                //hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatorequi/requiformato.php?folio=" + hp.Text;
                //gr.Cells[1].Controls.Add(hp);
                cont++;
            }

            if (cont > 0)
            {
                lblRequis.Visible = true;
                lblRequis.Text = "No. de partidas: " + cont;
            }
            else
            {
                lblRequis.Visible = true;
                lblRequis.Text = "No hay partidas pendientes";
            }
        }

        void requisiciones(int foliorequi, int foliopart)
        {
            int cont = 0;

            lblRequis.Visible = false;
            grdRequi.DataSource = BindGridView2(foliorequi, foliopart);
            grdRequi.DataMember = "PARTIDAS_PENDIENTES";
            grdRequi.DataBind();

            foreach (GridViewRow gr in grdRequi.Rows)
            {
                //HyperLink hp = new HyperLink();
                //hp.Text = gr.Cells[1].Text;
                //hp.Target = "blank_";
                //hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatorequi/requiformato.php?folio=" + hp.Text;
                //gr.Cells[1].Controls.Add(hp);
                cont++;
            }

            if (cont > 0)
            {
                lblRequis.Visible = true;
                lblRequis.Text = "No. de partidas: " + cont;
            }
            else
            {
                lblRequis.Visible = true;
                lblRequis.Text = "No hay partidas pendientes";
            }
        }

        protected void grdRequi_Sorting(object sender, GridViewSortEventArgs e)
        {
            string sortingDirection = string.Empty;
            if (direction == SortDirection.Ascending)
            {
                direction = SortDirection.Descending;
                grdRequi.HeaderStyle.CssClass = "descendingCssClass";
                sortingDirection = "Desc";
            }
            else
            {
                direction = SortDirection.Ascending;
                grdRequi.HeaderStyle.CssClass = "ascendingCssClass";
                sortingDirection = "Asc";
            }

            DataView sortedView = new DataView(BindGridView());
            sortedView.Sort = e.SortExpression + " " + sortingDirection;
            Session["SortedView"] = sortedView;
            grdRequi.DataSource = sortedView;
            grdRequi.DataBind();

            //foreach (GridViewRow gr in grdRequi.Rows)
            //{
            //    HyperLink hp = new HyperLink();
            //    hp.Text = gr.Cells[1].Text;
            //    hp.Target = "blank_";
            //    hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatorequi/requiformato.php?folio=" + hp.Text;
            //    gr.Cells[1].Controls.Add(hp);
            //}
        }

        protected void grdRequi_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdRequi.PageIndex = e.NewPageIndex;
            if (Session["SortedView"] != null)
            {
                grdRequi.DataSource = Session["SortedView"];
                grdRequi.DataBind();
            }
            else
            {
                grdRequi.DataSource = BindGridView();
                grdRequi.DataBind();
            }
        }

        public SortDirection direction
        {
            get
            {
                if (ViewState["directionState"] == null)
                {
                    ViewState["directionState"] = SortDirection.Ascending;
                }

                return (SortDirection)ViewState["directionState"];
            }

            set
            {
                ViewState["directionState"] = value;
            }
        }

        protected void btnFiltro_Click(object sender, EventArgs e)
        {
            if (txtFiltro.Equals(string.Empty))
            {
                requisiciones();
            }
            else if (rdbRequi.Checked)
            {
                requisiciones(int.Parse(txtFiltro.Text), 0);
            }
            else if (rdbPartida.Checked)
            {
                requisiciones(0, int.Parse(txtFiltro.Text));
            }
            else
            {
                lblRequis.Text = "**Debe seleccionar un objeto para filtrar**";
            }
        }

        protected void btnTodos_Click(object sender, EventArgs e)
        {
            requisiciones();
            rdbPartida.Checked = false;
            rdbRequi.Checked = false;
            txtFiltro.Text = "";
        }
    }
}