﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using webVeterinaria.svAgenda;

namespace webVeterinaria
{
    public partial class agendaInsert : System.Web.UI.Page
    {
        //svAgenda.IserviceAgendaClient svAgenda = new svAgenda.IserviceAgendaClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!IsPostBack)
                {
                    //cbxMotivoEv.DataSource = svAgenda.listarMotivo();
                    cbxMotivoEv.DataTextField = "DESCRIPCION";
                    cbxMotivoEv.DataValueField = "IDMOTIVO";
                    cbxMotivoEv.DataBind();

                   


                }


            }
        }
    }
}