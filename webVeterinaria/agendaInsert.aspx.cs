using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webVeterinaria
{
    public partial class agendaInsert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ListarMotivos();
                

            }
        }

        private void ListarMotivos()
        {
            SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=vet;User ID=sa;Password=les123");
            string query = "select DESCRIPCION from MOTIVO";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            DropDownList cbxMotivoEv = (DropDownList)FindControl("cbxMotivoEv");
            while (reader.Read())
            {
                string valor = reader["DESCRIPCION"].ToString();
                cbxMotivoEv.Items.Add(valor);
                

            }

        }
    }
}