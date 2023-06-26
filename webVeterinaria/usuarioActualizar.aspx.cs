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
        #region BUTTONS
        private void desactivarInputs()
        {
            txtUser.Enabled = false;
            txtPass.Enabled = false;
            txtEmail.Enabled = false;
            txtContact.Enabled = false;
            txtName.Enabled = false;        
            cbxEstadoUsu.Enabled = false;
            cbxTipoUsu.Enabled = false;
            btnGuardar.Enabled = false;
           
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
            btnGuardar.Enabled = true;

        }
        #endregion

        #region buscarIdUsuario
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
                    string script = "Swal.fire('EXITO!!','USUARIO ENCONTRADO','success');";
                    ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", script, true);
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
                string script = "Swal.fire('ERROR!!','USUARIO NO ENCONTRADO','error');";
                ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", script, true);
                
            }
           
        }
        #endregion

        protected void btn_buscar_Click(object sender, EventArgs e)
        {
            buscarUser(int.Parse(txtId.Text));
            activarInputs();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            int estado = Convert.ToInt32(cbxEstadoUsu.SelectedValue);
            int tipo = Convert.ToInt32(cbxTipoUsu.SelectedValue);
            ouser.USUARIO=txtUser.Text;
            ouser.CORREO=txtEmail.Text;
            ouser.CONTRASEÑA=txtPass.Text;
            ouser.CELULAR=txtContact.Text;
            ouser.ESTADOUSUARIO = estado;
            ouser.TIPOUSU=tipo;
            ouser.NOMBRECOMPLETO=txtName.Text;
            string m=svUser.ActualizarUsuario(ouser,id);

         
            string script = "Swal.fire('EXITO!!','" + m + "','success');";
            ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", script, true);
            buscarUser(id);
            


            
        }
    }
}