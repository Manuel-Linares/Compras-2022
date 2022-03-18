using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsCompras_Hgo.Sistemas
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargaRequi();
                cargaPartidas();
                cargaCompras();
                if (Request.QueryString["msg"].Equals("1"))
                {
                    ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Registrado correctamente');", true);
                }
                else if (Request.QueryString["msg"].Equals("2"))
                {
                    ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Registro editado correctamente');", true);
                }
            }
        }

        public void cargaValores(string query, Label label)
        {
            MySqlConnection _conn = new MySqlConnection(Application["cnn"].ToString());
            try
            {
                _conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, _conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    label.Text = rdr[0].ToString();
                }

                rdr.Close();
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Error en BD');", true);
            }

            _conn.Close();
        }

        public void cargaRequi()
        {
            cargaValores("SELECT COUNT(A.FOLIO) FROM requi A, usuarios B WHERE A.userid = B.id AND B.plaza = " + Session["plaza"].ToString() + ";", lblRecibidas);
            cargaValores("SELECT COUNT(A.FOLIO) FROM requi A, usuarios B WHERE A.userid = B.id AND B.plaza = " + Session["plaza"].ToString() + " AND estatus='Compras';", lblProcCompra);
            cargaValores("SELECT COUNT(A.FOLIO) FROM requi A, usuarios B WHERE A.userid = B.id AND B.plaza = " + Session["plaza"].ToString() + " AND estatus ='Requisición';", lblPendAutDir);
            cargaValores("SELECT COUNT(A.FOLIO) FROM requi A, usuarios B WHERE A.userid = B.id AND B.plaza = " + Session["plaza"].ToString() + " AND estatus = 'Autorizada';", lblPendAutRM);
            cargaValores("SELECT COUNT(A.FOLIO) FROM requi A, usuarios B WHERE A.userid = B.id AND B.plaza = " + Session["plaza"].ToString() + " AND estatus = 'Reembolso / Servicio';", lblReemServ);
            cargaValores("SELECT COUNT(A.FOLIO) FROM requi A, usuarios B WHERE A.userid = B.id AND B.plaza = " + Session["plaza"].ToString() + " AND estatus = 'Revisión';", lblRevis);
            cargaValores("SELECT COUNT(A.FOLIO) FROM requi A, usuarios B WHERE A.userid = B.id AND B.plaza = " + Session["plaza"].ToString() + " AND estatus = 'No Autorizada';", lblNoAut);
            cargaValores("SELECT COUNT(A.FOLIO) FROM requi A, usuarios B WHERE A.userid = B.id AND B.plaza = " + Session["plaza"].ToString() + " AND estatus = 'Finalizada';", lblFinalizadas);
        }

        public void cargaPartidas()
        {
            cargaValores("SELECT COUNT(A.folio) FROM detalle A, usuarios B, requi C WHERE A.foliorequi = C.FOLIO AND B.id = C.userid AND B.plaza = " + Session["plaza"].ToString() + ";", lblPartRec);
            cargaValores("SELECT COUNT(A.folio) FROM detalle A, usuarios B, requi C WHERE A.foliorequi = C.FOLIO AND B.id = C.userid AND B.plaza = " + Session["plaza"].ToString() + " AND A.estatus='Finalizada';", lblPartFin);
            cargaValores("SELECT COUNT(A.folio) FROM detalle A, usuarios B, requi C WHERE A.foliorequi = C.FOLIO AND B.id = C.userid AND B.plaza = " + Session["plaza"].ToString() + " AND A.estatus='Pendiente';", lblPartPend);
            cargaValores("SELECT COUNT(A.folio) FROM detalle A, usuarios B, requi C WHERE A.foliorequi = C.FOLIO AND B.id = C.userid AND B.plaza = " + Session["plaza"].ToString() + " AND A.reembolso = 'Si';", lblReemb);
        }

        public void cargaCompras()
        {
            // Tiempos de compra
            cargaValores("SELECT AVG(TO_DAYS(A.fe_modificacion )-TO_DAYS(A.fe_creacion)) FROM requi A, usuarios B WHERE  A.userid = B.id AND B.plaza = " + Session["plaza"].ToString() + " AND estatus = 'Finalizada';", lblDiasReq);
            cargaValores("SELECT AVG(TO_DAYS(d.`fe_ultimaact`)-TO_DAYS(r.`FE_CREACION`)) FROM detalle AS d,requi AS r, usuarios AS u WHERE d.`reembolso`='No'AND d.`estatus`='Finalizada' AND d.`foliorequi` = r.`FOLIO` AND r.`userid`=u.`id` AND u.`plaza` = " + Session["plaza"].ToString() + ";", lblDiasPart);

            // Ordenes de compra
            cargaValores("SELECT COUNT(*) FROM odecompra  WHERE YEAR (fechacreacion)= YEAR (NOW()) AND odecompra.`estatus` = 'Autorizada RM';", lblODC);
        }
    }
}