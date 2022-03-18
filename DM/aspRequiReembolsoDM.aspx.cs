using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsCompras_Hgo.DM
{
    public partial class Formulario_web13 : System.Web.UI.Page
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

        private DataTable BindGridView()
        {
            ds = new DataSet();
            ds = obj.listarReembolsoServ(Application["cnn"].ToString(), int.Parse(Session["idUsuario"].ToString()));
            return ds.Tables[0];
        }

        void requisiciones()
        {
            int cont = 0;

            lblRequis.Visible = false;
            grdRequi.DataSource = BindGridView();
            grdRequi.DataMember = "REEMBOLSOSERVICIO";
            grdRequi.DataBind();
            foreach (GridViewRow gr in grdRequi.Rows)
            {
                HyperLink hp = new HyperLink();
                switch (Session["plaza"].ToString())
                {
                    case "1":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoEdoMex/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "2":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoOCC/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "3":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoOax/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "4":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoAgs/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "5":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoCoa/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "6":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoGto/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "7":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatorequi/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "8":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoChh/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "9":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoChp/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "10":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoQroo/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "11":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoNeza/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "12":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoYuc/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "13":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoTam/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "14":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoDur/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "15":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoVer/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "16":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoSon/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "17":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoBCS/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "18":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoPue/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "19":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoCDMX/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "20":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoGro/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "21":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoMich/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "22":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoBC/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                }
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
            foreach (GridViewRow gr in grdRequi.Rows)
            {
                HyperLink hp = new HyperLink();
                switch (Session["plaza"].ToString())
                {
                    case "1":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoEdoMex/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "2":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoOCC/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "3":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoOax/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "4":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoAgs/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "5":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoCoa/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "6":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoGto/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "7":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatorequi/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "8":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoChh/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "9":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoChp/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "10":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoQroo/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "11":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoNeza/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "12":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoYuc/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "13":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoTam/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "14":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoDur/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "15":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoVer/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "16":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoSon/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "17":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoBCS/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "18":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoPue/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "19":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoCDMX/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "20":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoGro/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "21":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoMich/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "22":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoBC/requiformato.php?folio=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                }
            }
        }

        protected void grdRequi_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdRequi.PageIndex = e.NewPageIndex;
            if (Session["SortedView"] != null)
            {
                grdRequi.DataSource = Session["SortedView"];
                grdRequi.DataBind();
                foreach (GridViewRow gr in grdRequi.Rows)
                {
                    HyperLink hp = new HyperLink();
                    switch (Session["plaza"].ToString())
                    {
                        case "1":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoEdoMex/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "2":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoOCC/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "3":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoOax/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "4":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoAgs/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "5":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoCoa/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "6":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoGto/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "7":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatorequi/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "8":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoChh/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "9":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoChp/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "10":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoQroo/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "11":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoNeza/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "12":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoYuc/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "13":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoTam/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "14":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoDur/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "15":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoVer/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "16":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoSon/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "17":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoBCS/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "18":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoPue/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "19":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoCDMX/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "20":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoGro/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "21":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoMich/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "22":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoBC/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                    }
                }
            }
            else
            {
                grdRequi.DataSource = BindGridView();
                grdRequi.DataBind();
                foreach (GridViewRow gr in grdRequi.Rows)
                {
                    HyperLink hp = new HyperLink();
                    switch (Session["plaza"].ToString())
                    {
                        case "1":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoEdoMex/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "2":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoOCC/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "3":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoOax/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "4":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoAgs/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "5":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoCoa/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "6":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoGto/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "7":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatorequi/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "8":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoChh/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "9":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoChp/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "10":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoQroo/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "11":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoNeza/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "12":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoYuc/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "13":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoTam/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "14":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoDur/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "15":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoVer/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "16":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoSon/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "17":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoBCS/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "18":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoPue/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "19":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoCDMX/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "20":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoGro/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "21":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoMich/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                        case "22":
                            hp.Text = gr.Cells[0].Text;
                            hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoBC/requiformato.php?folio=" + hp.Text;
                            hp.Target = "_blank";
                            gr.Cells[0].Controls.Add(hp);
                            break;
                    }
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