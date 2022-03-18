using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace wsCompras_Hgo
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        ClsPrincipal _obj = new ClsPrincipal();
        DataSet _dsInicio;// Data set local a la pagina
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ses"].Equals("1"))
            {
                ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Sesion cerrada');", true);
            }
            else if (Request.QueryString["ses"].Equals("2"))
            {
                ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Favor de iniciar sesión');", true);
            }
        }

        protected void btnInicio_Click(object sender, EventArgs e)
        {
            MySqlConnection _conn = new MySqlConnection(Application["cnn"].ToString());
            bool ban = false;
            string[] arreglo = new string[7];
            int i = 0;
            try
            {
                /*_dsInicio = new DataSet();
                _dsInicio = _obj.IniciarSesion(txtUsuario.Text, txtContra.Text, Application["cnn"].ToString());*/
                string query = "CALL acceder('" + txtUsuario.Text + "', '" + txtContra.Text + "');";


                _conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, _conn);
                cmd.CommandTimeout = 100;
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (rdr[0].ToString() != "-1")
                    {
                        ban = true;
                    }
                    else
                    {
                        ban = false;
                    }

                    if (ban)
                    {
                        arreglo[0] = rdr[0].ToString();
                        arreglo[1] = rdr[1].ToString();
                        arreglo[2] = rdr[2].ToString();
                        arreglo[3] = rdr[3].ToString();
                        arreglo[4] = rdr[4].ToString();
                        arreglo[5] = rdr[5].ToString();
                        arreglo[6] = rdr[6].ToString();
                    }
                }

                rdr.Close();
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Error en BD'" + ex.ToString() + ");", true);
            }

            _conn.Close();

            if (ban)
            {
                for (int k = 0; k < arreglo.Length; k++)
                {
                    switch (k)
                    {
                        case 0:
                            Session["idUsuario"] = int.Parse(arreglo[k]);
                            break;
                        case 1:
                            Session["nomUsuario"] = arreglo[k];
                            break;
                        case 2:
                            Session["nombre"] = arreglo[k];
                            break;
                        case 3:
                            Session["plaza"] = int.Parse(arreglo[k]);
                            break;
                        case 4:
                            Session["userlevel"] = int.Parse(arreglo[k]);
                            break;
                        case 5:
                            if (!Session["userlevel"].Equals(-1))
                            {
                                Session["area"] = int.Parse(arreglo[k]);
                            }
                            else
                            {
                                Session["area"] = 0;
                            }

                            break;
                        case 6:
                            if (!arreglo[k].Equals(string.Empty))
                            {
                                Session["subarea"] = int.Parse(arreglo[k]);
                            }

                            break;
                    }
                }

                switch (Session["userlevel"])
                {
                    case -1:
                        Response.Redirect("~/aspIndex.aspx?msg=0");
                        break;
                    case 10:
                        Response.Redirect("~/Usuario/aspInicioUsu.aspx?msg=0");
                        break;
                    case 12:
                        Response.Redirect("~/DM/aspInicioDM.aspx?msg=0");
                        break;
                    case 13:
                        Response.Redirect("~/DG/aspInicioDG.aspx?msg=0");
                        break;
                    case 15:
                        Response.Redirect("~/RRMM/aspInicioRRMM.aspx?msg=0");
                        break;
                    case 16:
                        Response.Redirect("~/Sistemas/aspInicioSistemas.aspx?msg=0");
                        break;
                    case 17:
                        Response.Redirect("~/Compras/aspInicioCompras.aspx?msg=0");
                        break;
                }

            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Usuario y/o contraseña incorrectos');", true);
            }
        }
    }
}