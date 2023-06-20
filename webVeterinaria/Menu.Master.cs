﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webVeterinaria
{
    public partial class Menu : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["userName"] != null)
                {
                    lblUser.Text = Session["userName"].ToString();
                    lblTipoUsu.Text = Session["tipoUsu"].ToString();
                }
                else
                {
                    Response.Redirect("Inicio.aspx");
                    
                }
            }
            

        }

        protected void lblSalir_Click(object sender, EventArgs e)
        {
           
            Session.RemoveAll();          
            Response.Redirect("Inicio.aspx");
        }
    }
}