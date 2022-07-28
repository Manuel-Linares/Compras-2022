using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsCompras_Hgo.RRMM
{
    public partial class Formulario_web116 : System.Web.UI.Page
    {
        DataSet ds;
        ClsPrincipal obj = new ClsPrincipal();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ODC();
            }
        }

        private DataTable BindGridView()
        {
            ds = new DataSet();
            ds = obj.listarODCRevision(Application["cnn"].ToString(), int.Parse(Session["plaza"].ToString()));
            return ds.Tables[0];
        }

        void ODC()
        {
            int cont = 0;

            lblRequis.Visible = false;
            grdODC.DataSource = BindGridView();
            grdODC.DataMember = "ODC_REVISION";
            grdODC.DataBind();

            foreach (GridViewRow gr in grdODC.Rows)
            {
                HyperLink hp = new HyperLink();
                switch (Session["plaza"].ToString())
                {
                    case "1":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoEdoMex/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "2":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoOCC/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "3":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoOax/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "4":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoAgs/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "5":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoCoa/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "6":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoGto/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "7":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatorequi/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "8":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoChh/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "9":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoChp/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "10":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoQroo/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "11":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoNeza/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "12":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoYuc/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "13":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoTam/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "14":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoDur/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "15":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoVer/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "16":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoSon/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "17":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoBCS/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "18":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoPue/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "19":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoCDMX/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "20":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoGro/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "21":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoMich/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "22":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoBC/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                }
            }

            if (cont > 0)
            {
                lblRequis.Visible = true;
                lblRequis.Text = "No. de ODC: " + cont;
            }
            else
            {
                lblRequis.Visible = true;
                lblRequis.Text = "No se han realizado ODC";
            }
        }

        protected void grdODC_Sorting(object sender, GridViewSortEventArgs e)
        {
            string sortingDirection = string.Empty;
            if (direction == SortDirection.Ascending)
            {
                direction = SortDirection.Descending;
                grdODC.HeaderStyle.CssClass = "descendingCssClass";
                sortingDirection = "Desc";
            }
            else
            {
                direction = SortDirection.Ascending;
                grdODC.HeaderStyle.CssClass = "ascendingCssClass";
                sortingDirection = "Asc";
            }

            DataView sortedView = new DataView(BindGridView());
            sortedView.Sort = e.SortExpression + " " + sortingDirection;
            Session["SortedView"] = sortedView;
            grdODC.DataSource = sortedView;
            grdODC.DataBind();

            foreach (GridViewRow gr in grdODC.Rows)
            {
                HyperLink hp = new HyperLink();
                switch (Session["plaza"].ToString())
                {
                    case "1":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoEdoMex/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "2":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoOCC/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "3":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoOax/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "4":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoAgs/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "5":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoCoa/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "6":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoGto/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "7":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatorequi/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "8":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoChh/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "9":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoChp/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "10":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoQroo/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "11":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoNeza/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "12":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoYuc/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "13":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoTam/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "14":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoDur/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "15":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoVer/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "16":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoSon/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "17":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoBCS/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "18":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoPue/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "19":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoCDMX/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "20":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoGro/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "21":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoMich/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                    case "22":
                        hp.Text = gr.Cells[1].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoBC/odcformato.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[1].Controls.Add(hp);
                        break;
                }
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