using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webVeterinaria.svUser;

namespace webVeterinaria
{
    public partial class usuarioRegistro : System.Web.UI.Page
    {
        svUser.IserviceUsersClient svUser = new svUser.IserviceUsersClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                if (!IsPostBack)
                {
                    cbxTipoUsu.DataSource = svUser.listarTipo();
                    cbxTipoUsu.DataTextField = "TIPOUSU";
                    cbxTipoUsu.DataValueField = "IDTIPO";
                    cbxTipoUsu.DataBind();

                    cbxEstadoUsu.DataSource = svUser.listarEstado();
                    cbxEstadoUsu.DataTextField = "ESTADO";
                    cbxEstadoUsu.DataValueField = "IDESTADO";
                    cbxEstadoUsu.DataBind();


                }


            }
        }
        private void Limpiar()
        {
            txtUser.Text = "";
            txtPass.Text = "";
            txtName.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            cbxEstadoUsu.SelectedIndex = 0;
            cbxTipoUsu.SelectedIndex = 0;
        }
        private void RegUsers()
        {
            string script;
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtContact.Text))
            {
                script = "Swal.fire('ERROR!!','Debes completar todos los campos','error');";
                ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", script, true);
                return;
            }
            int estado = int.Parse(cbxEstadoUsu.SelectedValue);
            int tipo = int.Parse(cbxTipoUsu.SelectedValue);
            Users regUser = new Users();
            regUser.TIPOUSU = tipo;
            regUser.USUARIO = txtUser.Text.Trim();
            regUser.CONTRASEÑA = txtPass.Text.Trim();
            regUser.NOMBRECOMPLETO = txtName.Text.Trim();
            regUser.CORREO = txtEmail.Text.Trim();
            regUser.ESTADOUSUARIO = estado;
            regUser.CELULAR = txtContact.Text.Trim();
            string m = svUser.AgregarUsuario(regUser);
            script = $"Swal.fire('EXITO!!','"+m+"','success');";
            ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", script, true);
            
            Limpiar();

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegUsers();
        }
    }
}