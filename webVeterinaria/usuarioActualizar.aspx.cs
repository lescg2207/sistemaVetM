using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webVeterinaria.svUser;

namespace webVeterinaria
{
    public partial class usuarioActualizar : System.Web.UI.Page
    {
        svUser.IserviceUsersClient svUser = new svUser.IserviceUsersClient();
        Users ouser= new Users();
        protected void Page_Load(object sender, EventArgs e)
        {
            desactivarInputs();
            if (! Page.IsPostBack)
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

        private void desactivarInputs()
        {
            txtUser.Enabled = false;
            txtPass.Enabled = false;
            txtEmail.Enabled = false;
            txtContact.Enabled = false;
            txtName.Enabled = false;        
            cbxEstadoUsu.Enabled = false;
            cbxTipoUsu.Enabled = false;
           
        }
        private void activarInputs()
        {
            txtUser.Enabled = true;
            txtPass.Enabled = true;
            txtEmail.Enabled = true;
            txtContact.Enabled = true;
            txtName.Enabled = true;
            cbxEstadoUsu.Enabled = true;
            cbxTipoUsu.Enabled = true;

        }
        private void buscarUser(int id)
        {
                   
            ouser = svUser.BuscarUsuario(id);
            try{
                if (ouser != null)
                {
                    txtUser.Text = ouser.USUARIO;
                    txtPass.Text = ouser.CONTRASEÑA;
                    txtEmail.Text = ouser.CORREO;
                    txtContact.Text = ouser.CELULAR;
                    txtName.Text = ouser.NOMBRECOMPLETO;
                    cbxEstadoUsu.SelectedValue = ouser.ESTADOUSUARIO.ToString();
                    cbxTipoUsu.SelectedValue = ouser.TIPOUSU.ToString();
                }
                else
                {
  
                    
                    txtUser.Text = "";
                    txtPass.Text = "";
                    txtEmail.Text = "";
                    txtContact.Text = "";
                    txtName.Text = "";
                    cbxEstadoUsu.Text = "";
                    cbxTipoUsu.Text = "";
                    txtId.Focus();

                }

            }
            catch
            {
                Response.Write("<script>alert('USUARIO NO ENCONTRADO');</script>");
            }
           
        }

        protected void btn_buscar_Click(object sender, EventArgs e)
        {
            buscarUser(int.Parse(txtId.Text));
            activarInputs();
        }
    }
}