using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsCompras_Hgo.DG
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
            }
        }

        private DataTable BindGridView()
        {
            ds = new DataSet();
            ds = obj.listarOPDG(Application["cnn"].ToString(), int.Parse(Session["plaza"].ToString()));
            return ds.Tables[0];
        }

        void requisiciones()
        {
            int cont = 0;

            lblRequis.Visible = false;
            grdRequi.DataSource = BindGridView();
            grdRequi.DataMember = "OPDG";
            grdRequi.DataBind();

            foreach (GridViewRow gr in grdRequi.Rows)
            {
                HyperLink hp = new HyperLink();

                hp.Text = gr.Cells[8].Text;
                hp.NavigateUrl = "..\\ODP\\" + hp.Text;
                hp.Target = "_blank";
                gr.Cells[8].Controls.Add(hp);

                cont++;
            }

            if (cont > 0)
            {
                lblRequis.Visible = true;
                lblRequis.Text = "No. de Órdenes de Pago: " + cont;
            }
            else
            {
                lblRequis.Visible = true;
                lblRequis.Text = "No hay órdenes de pago por autorizar";
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string confirmValue = Request.Form["confirm_value"];

            if (confirmValue == "Sí")
            {
                LinkButton lnk = sender as LinkButton;
                GridViewRow row = (GridViewRow)lnk.NamingContainer;
                MySqlConnection _conn = new MySqlConnection(Application["cnn"].ToString());

                try
                {
                    /*_dsInicio = new DataSet();
                    _dsInicio = _obj.IniciarSesion(txtUsuario.Text, txtContra.Text, Application["cnn"].ToString());*/
                    string query = "CALL editarOP(" + lnk.CommandArgument + "," + Session["idUsuario"].ToString() + ",'Autorizada DG');";

                    _conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, _conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        if (rdr[0].ToString() == "1")
                        {
                            // Inserción exitosa
                            Page.ClientScript.RegisterStartupScript(GetType(), "alert", "alert('OP Autorizada')", true);
                            requisiciones();
                        }
                        else
                        {
                            // Error
                            ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('No se pudo autorizar');", true);
                        }
                    }

                    rdr.Close();
                }
                catch (Exception ex)
                {
                    ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Error en BD');", true);
                    Response.Write("<script>alert('Error en BD');</script>");
                }

                _conn.Close();
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            string confirmValue = Request.Form["confirm_value"];

            if (confirmValue == "No")
            {
                LinkButton lnk = sender as LinkButton;
                GridViewRow row = (GridViewRow)lnk.NamingContainer;
                MySqlConnection _conn = new MySqlConnection(Application["cnn"].ToString());

                try
                {
                    /*_dsInicio = new DataSet();
                    _dsInicio = _obj.IniciarSesion(txtUsuario.Text, txtContra.Text, Application["cnn"].ToString());*/
                    string query = "CALL editarOP(" + lnk.CommandArgument + "," + Session["idUsuario"].ToString() + ",'Cancelada DG');";

                    _conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, _conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        if (rdr[0].ToString() == "1")
                        {
                            // Inserción exitosa
                            Page.ClientScript.RegisterStartupScript(GetType(), "alert", "alert('OP cancelada')", true);
                            requisiciones();
                        }
                        else
                        {
                            // Error
                            ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('No se pudo cancelar');", true);
                        }
                    }

                    rdr.Close();
                }
                catch (Exception ex)
                {
                    ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Error en BD');", true);
                    Response.Write("<script>alert('Error en BD');</script>");
                }

                _conn.Close();
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

        protected void grdRequi_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }
    }
}