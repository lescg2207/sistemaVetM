using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webVeterinaria.ServiceAlmacen;

namespace webVeterinaria
{
    public partial class CRUDALMACEN : System.Web.UI.Page
    {
        ServiceAlmacen.ServicioAlmacenClient alma = new ServiceAlmacen.ServicioAlmacenClient();
        private void BindRegRecordsInGrid()
        {
            DataSet ds = new DataSet();
            ds = alma.ObtenerAlmacen();
            grdWcfTest.DataSource = ds;
            grdWcfTest.DataBind();
        }
        private void ActualizarAlmacen()
        {
            clsAlmacen almacen = new clsAlmacen();
            almacen.IDITEM = Convert.ToInt32(ViewState["IDITEM"].ToString());
            almacen.NOMBRE = txtNombre.Text.Trim();
            almacen.PRESENTACION = txtPresentacion.Text.Trim();
            almacen.PRECIO = Convert.ToDouble(txtPrecio.Text.Trim());
            almacen.STOCK = Convert.ToInt32(txtStock.Text.Trim());
            almacen.ESTADO = Convert.ToInt32(ddlEstado.SelectedIndex.ToString());
            alma.ActualizarAlmacen(almacen);
            lblStatus.Text = alma.ActualizarAlmacen(almacen);
            ClearControls();
            BindRegRecordsInGrid();
        }
        private void InsertarAlmacen()
        {
            clsAlmacen almacen = new clsAlmacen();
            almacen.NOMBRE = txtNombre.Text.Trim();
            almacen.PRESENTACION = txtPresentacion.Text.Trim();
            almacen.PRECIO = Convert.ToDouble(txtPrecio.Text.Trim());
            almacen.STOCK = Convert.ToInt32(txtStock.Text.Trim());
            almacen.ESTADO = Convert.ToInt32(ddlEstado.SelectedIndex.ToString());
            lblStatus.Text = alma.AgregarAlmacen(almacen);
            ClearControls();
            BindRegRecordsInGrid();
        }

        private void ClearControls()
        {
            txtNombre.Text = string.Empty;
            txtPresentacion.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtStock.Text = string.Empty;
            ddlEstado.SelectedIndex = 0;
            btnSubmit.Text = "Submit";
            txtNombre.Focus();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {


                BindRegRecordsInGrid();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnSubmit.Text == "Actualizar")
            {
                ActualizarAlmacen();
            }
            else
            {
                InsertarAlmacen();
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
            lblStatus.Text = string.Empty;
        }

        protected void grdWcfTest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void imgDel_Command(object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {
            clsAlmacen almacen = new clsAlmacen();
            almacen.IDITEM = int.Parse(e.CommandArgument.ToString());
            if (alma.ElimnarAlmacen(almacen) == true)
            {
                lblStatus.Text = "DATOS ELIMINADOS EXITOSAMENTE";
            }
            else
            {
                lblStatus.Text = "ERROR AL ELIMINAR LOS DATOS ";
            }
            BindRegRecordsInGrid();
        }
        protected void imgEdit_Command(object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {
            clsAlmacen almacen = new clsAlmacen();
            almacen.IDITEM = int.Parse(e.CommandArgument.ToString());
            ViewState["IDITEM"] = almacen.IDITEM;
            DataSet ds = new DataSet();
            ds = alma.FetchUpdatedRecords(almacen);

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtNombre.Text = ds.Tables[0].Rows[0]["NOMBRE"].ToString();
                txtPresentacion.Text = ds.Tables[0].Rows[0]["PRESENTACION"].ToString();
                txtPrecio.Text = ds.Tables[0].Rows[0]["PRECIO"].ToString();
                txtStock.Text = ds.Tables[0].Rows[0]["STOCK"].ToString();
                ddlEstado.Text = ds.Tables[0].Rows[0]["ESTADO"].ToString();
                btnSubmit.Text = "Actualizar";
            }
        }
        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("BuscarAlmacen.aspx");
        }
    }
}