using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsCompras_Hgo
{
    public partial class Formulario_web122 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        void Page_PreInit(object sender, EventArgs e)
        {
            MasterPageFile = Session["master"].ToString();
        }
    }
}