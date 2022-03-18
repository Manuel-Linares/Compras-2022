using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsCompras_Hgo
{
    public partial class Formulario_web114 : System.Web.UI.Page
    {
        DataSet ds;
        ClsPrincipal obj = new ClsPrincipal();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                usuarios();
            }
        }

        private DataTable BindGridView()
        {
            ds = new DataSet();
            ds = obj.listarUsuarios(Application["cnn"].ToString());
            return ds.Tables[0];
        }

        void usuarios()
        {
            int cont = 0;

            lblRequis.Visible = false;
            grdUsu.DataSource = BindGridView();
            grdUsu.DataMember = "REEMBOLSOSERVICIO";
            grdUsu.DataBind();
            foreach (GridViewRow gr in grdUsu.Rows)
            {
                cont++;
            }

            if (cont > 0)
            {
                lblRequis.Visible = true;
                lblRequis.Text = "No. de usuarios: " + cont;
            }
            else
            {
                lblRequis.Visible = true;
                lblRequis.Text = "No hay usuarios registrados";
            }
        }

        protected void grdUsu_Sorting(object sender, GridViewSortEventArgs e)
        {
            string sortingDirection = string.Empty;
            if (direction == SortDirection.Ascending)
            {
                direction = SortDirection.Descending;
                grdUsu.HeaderStyle.CssClass = "descendingCssClass";
                sortingDirection = "Desc";
            }
            else
            {
                direction = SortDirection.Ascending;
                grdUsu.HeaderStyle.CssClass = "ascendingCssClass";
                sortingDirection = "Asc";
            }

            DataView sortedView = new DataView(BindGridView());
            sortedView.Sort = e.SortExpression + " " + sortingDirection;
            Session["SortedView"] = sortedView;
            grdUsu.DataSource = sortedView;
            grdUsu.DataBind();
        }

        protected void grdUsu_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdUsu.PageIndex = e.NewPageIndex;
            if (Session["SortedView"] != null)
            {
                grdUsu.DataSource = Session["SortedView"];
                grdUsu.DataBind();
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
    }
}