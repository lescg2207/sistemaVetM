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
            int cargo = usera.TIPOUSU;
            if(cargo == 1 )
            {
                Session["tipoUsu"] = "Administrador";
            }
            else
            {
                Session["tipoUsu"] = "Operador";
            }

            if (usera.ESTADOUSUARIO ==1)
            {
                Session["userName"] = usera.NOMBRECOMPLETO.ToString();
                Response.Redirect("menuDash.aspx");

            }
            else if(usera.ESTADOUSUARIO ==2)
            {
                lblMensaje.Text = "Usuario inactivo, comuniquese con "+"</br>"+"su administrador";
            }
            else
            {
                lblMensaje.Text = "Usuario o contraseña incorrectos";
            }

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            validarLogin();
        }
    }
}