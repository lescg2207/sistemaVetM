using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webVeterinaria.svUser;

namespace webVeterinaria
{
    public partial class Login : System.Web.UI.Page
    {
        svUser.IserviceUsersClient svUser = new svUser.IserviceUsersClient();
        Users usera = new Users();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void validarLogin()
        {
            string user=txtUser.Text;
            string pass=txtPass.Text;           
            usera =svUser.validarLogin(user,pass);
            

            if (usera.ESTADO =="Activo")
            {
                Session["userName"] = usera.NOMBRECOMPLETO.ToString();
                Session["tipoUsu"] = usera.TIPO.ToString();
                Response.Redirect("menuDash.aspx");

            }
            else if(usera.ESTADO =="Inactivo")
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Usuario inactivo, comuniquese con "+"</br>"+"su administrador";

            }else if (user=="" )
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Falta ingresar usuario";
                txtUser.Focus();

            }else if ( pass == "")
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Falta ingresar contraseña";
                txtPass.Focus();
            }
            else
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Usuario o contraseña incorrectos";
            }

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            validarLogin();
        }
    }
}