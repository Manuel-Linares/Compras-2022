﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace wsCompras_Hgo
{
    public partial class Formulario_web115 : System.Web.UI.Page
    {
        int id = 0;
        DataSet ds;
        DataTable dt;
        ClsPrincipal obj = new ClsPrincipal();

        protected void Page_Load(object sender, EventArgs e)
        {
            id = int.Parse(Request.QueryString["id"]);
            if (!IsPostBack)
            {
                LlenarUserlevel();
                LlenarPlaza();
                LlenarArea();
                LlenarSubarea();
                LlenarPuesto();
                usuario();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        public void usuario()
        {
            dt = obj.DatosUsuario(Application["cnn"].ToString(), id);

            if (dt.Rows.Count > 0)
            {
                lblId.Text = dt.Rows[0]["id"].ToString();
                lblUsuario.Text = dt.Rows[0]["Usuario"].ToString();
                txtNombre.Text = dt.Rows[0]["Nombre"].ToString();
                txtContra.TextMode = TextBoxMode.SingleLine;
                txtContra.Text = dt.Rows[0]["password"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                dwlUserlevel.SelectedValue = dt.Rows[0]["Userlevel"].ToString();
                dwlStatus.SelectedValue = dt.Rows[0]["Status"].ToString();
                dwlPlaza.SelectedValue = dt.Rows[0]["Plaza"].ToString();
                dwlArea.SelectedValue = dt.Rows[0]["Área"].ToString();
                dwlSubarea.SelectedValue = dt.Rows[0]["Subarea"].ToString();
                dwlPuesto.SelectedValue = dt.Rows[0]["Puesto"].ToString();
            }
        }

        public void LlenarUserlevel()
        {
            // Limpia los datos del data set para reinciarlo
            ds = new DataSet();
            ds = obj.ConsultaUserLevel(Application["cnn"].ToString()); // Ejecutara el metodo que muestra a todos los tipos de empleados
            dwlUserlevel.DataSource = ds; // Asigna valores de la consulta
            dwlUserlevel.DataMember = "userlevels"; // Alias que se utilizo en la clase
            dwlUserlevel.DataValueField = "userlevelid"; // Toma la propiedad de value
            dwlUserlevel.DataTextField = "userlevelname";// Se visualiza y lo toma ITEM
            dwlUserlevel.DataBind();// Permite que se vean los datos en el control y en la pagina web
            // Inserta un nuevo valor que no viene de la base de datos
        }

        public void LlenarPlaza()
        {
            // Limpia los datos del data set para reinciarlo
            ds = new DataSet();
            ds = obj.ConsultaPlaza(Application["cnn"].ToString()); // Ejecutara el metodo que muestra a todos los tipos de empleados
            dwlPlaza.DataSource = ds; // Asigna valores de la consulta
            dwlPlaza.DataMember = "plaza"; // Alias que se utilizo en la clase
            dwlPlaza.DataValueField = "plaza"; // Toma la propiedad de value
            dwlPlaza.DataTextField = "crit";// Se visualiza y lo toma ITEM
            dwlPlaza.DataBind();// Permite que se vean los datos en el control y en la pagina web
            // Inserta un nuevo valor que no viene de la base de datos
        }

        public void LlenarArea()
        {
            // Limpia los datos del data set para reinciarlo
            ds = new DataSet();
            ds = obj.ConsultaArea(Application["cnn"].ToString()); // Ejecutara el metodo que muestra a todos los tipos de empleados
            dwlArea.DataSource = ds; // Asigna valores de la consulta
            dwlArea.DataMember = "area"; // Alias que se utilizo en la clase
            dwlArea.DataValueField = "id"; // Toma la propiedad de value
            dwlArea.DataTextField = "area";// Se visualiza y lo toma ITEM
            dwlArea.DataBind();// Permite que se vean los datos en el control y en la pagina web
            // Inserta un nuevo valor que no viene de la base de datos
        }

        public void LlenarSubarea()
        {
            // Limpia los datos del data set para reinciarlo
            ds = new DataSet();
            ds = obj.ConsultaSubarea(Application["cnn"].ToString()); // Ejecutara el metodo que muestra a todos los tipos de empleados
            dwlSubarea.DataSource = ds; // Asigna valores de la consulta
            dwlSubarea.DataMember = "subarea"; // Alias que se utilizo en la clase
            dwlSubarea.DataValueField = "id"; // Toma la propiedad de value
            dwlSubarea.DataTextField = "subarea";  // Se visualiza y lo toma ITEM
            dwlSubarea.DataBind(); // Permite que se vean los datos en el control y en la pagina web

            // Inserta un nuevo valor que no viene de la base de datos
        }

        public void LlenarPuesto()
        {
            // Limpia los datos del data set para reinciarlo
            ds = new DataSet();
            ds = obj.ConsultaPuesto(Application["cnn"].ToString()); // Ejecutara el metodo que muestra a todos los tipos de empleados
            dwlPuesto.DataSource = ds; // Asigna valores de la consulta
            dwlPuesto.DataMember = "puesto"; // Alias que se utilizo en la clase
            dwlPuesto.DataValueField = "id"; // Toma la propiedad de value
            dwlPuesto.DataTextField = "puesto"; // Se visualiza y lo toma ITEM
            dwlPuesto.DataBind(); // Permite que se vean los datos en el control y en la pagina web
            // Inserta un nuevo valor que no viene de la base de datos
        }
    }
}