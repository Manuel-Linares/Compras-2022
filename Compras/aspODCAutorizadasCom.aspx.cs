﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsCompras_Hgo.Compras
{
    public partial class Formulario_web115 : System.Web.UI.Page
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
            ds = obj.listarODCAutorizadas(Application["cnn"].ToString(), int.Parse(Session["plaza"].ToString()));
            return ds.Tables[0];
        }

        void ODC()
        {
            int cont = 0;

            lblRequis.Visible = false;
            grdODC.DataSource = BindGridView();
            grdODC.DataMember = "ODC_AUTORIZADAS";
            grdODC.DataBind();

            foreach (GridViewRow gr in grdODC.Rows)
            {
                HyperLink hp = new HyperLink();
                switch (Session["plaza"].ToString())
                {
                    case "1":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoEdoMex/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "2":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoOCC/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "3":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoOax/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "4":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoAgs/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "5":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoCoa/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "6":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoGto/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "7":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatorequi/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "8":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoChh/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "9":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoChp/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "10":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoQroo/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "11":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoNeza/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "12":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoYuc/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "13":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoTam/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "14":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoDur/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "15":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoVer/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "16":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoSon/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "17":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoBCS/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "18":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoPue/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "19":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoCDMX/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "20":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoGro/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "21":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoMich/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
                        break;
                    case "22":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoBC/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        cont++;
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
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoEdoMex/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "2":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoOCC/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "3":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoOax/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "4":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoAgs/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "5":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoCoa/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "6":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoGto/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "7":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatorequi/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "8":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoChh/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "9":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoChp/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "10":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoQroo/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "11":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoNeza/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "12":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoYuc/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "13":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoTam/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "14":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoDur/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "15":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoVer/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "16":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoSon/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "17":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoBCS/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "18":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoPue/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "19":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoCDMX/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "20":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoGro/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "21":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoMich/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
                        break;
                    case "22":
                        hp.Text = gr.Cells[0].Text;
                        hp.NavigateUrl = "https://controlsit.mx/comprasv2/formatoBC/odcautorizada.php?id=" + hp.Text;
                        hp.Target = "_blank";
                        gr.Cells[0].Controls.Add(hp);
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