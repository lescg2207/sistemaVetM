using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webVeterinaria
{
    public partial class BuscarAlmacen : System.Web.UI.Page
    {
        ServiceAlmacen.ServicioAlmacenClient alma = new ServiceAlmacen.ServicioAlmacenClient();
        private void BindRegRecordsInGrid()
        {
            DataSet ds = new DataSet();
            ds = alma.ObtenerAlmacen();
            grdWcfTest.DataSource = ds;
            grdWcfTest.DataBind();
        }

        public void buscaralmacen()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8RD4SAJ\\SQLEXPRESS;Database=vet ;integrated Security=true;");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT NOMBRE,PRESENTACION,PRECIO,STOCK FROM ALMACEN WHERE ESTADO = 1 AND NOMBRE like'%' + @nombre + '%'";
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtBuscar.Text.Trim();
            cmd.Connection = con;
            con.Open();
            grdWcfTest.DataSource = cmd.ExecuteReader();
            grdWcfTest.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindRegRecordsInGrid();
            }
        }

        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            buscaralmacen();
        }

        protected void BtnListar_Click(object sender, EventArgs e)
        {
            BindRegRecordsInGrid();
        }
    }
}