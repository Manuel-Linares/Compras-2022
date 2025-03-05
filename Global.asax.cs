using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace wsCompras_Hgo
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["cnn"] = ConfigurationManager.ConnectionStrings["con"].ConnectionString; //Se envia a la clase 
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["nomUsuario"] = "";
            Session["idUsuario"] = 0;
            Session["nombre"] = "";
            Session["plaza"] = 0;
            Session["userlevel"] = 0;
            Session["area"] = 0;
            Session["subarea"] = 0;
            Session["puesto"] = 0;
            Session.Timeout = 1200;

            Session["master"] = "";
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}