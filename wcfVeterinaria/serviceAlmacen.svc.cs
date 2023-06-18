using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcfVeterinaria
{
   
    public class serviceAlmacen : IserviceAlmacen
    {
        public string ActualizarAlmacen(Almacen almacen, int id)
        {
            throw new NotImplementedException();
        }

        public string AgregarAlmacen(Almacen almacen)
        {
            string Message;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-67GERHD\\SQLEXPRESS;Initial Catalog=vet;User ID=sa;Password=123456");

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into ALMACEN(NOMBRE,PRESENTACION,PRECIO,STOCK,ESTADO) values(@1,@2,@3,@4,@5)", con);
            cmd.Parameters.AddWithValue("@1", almacen.NOMBRE);
            cmd.Parameters.AddWithValue("@2", almacen.PRESENTACION);
            cmd.Parameters.AddWithValue("@3", almacen.PRECIO);
            cmd.Parameters.AddWithValue("@4", almacen.STOCK);
            cmd.Parameters.AddWithValue("@5", almacen.ESTADO);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Message = almacen.NOMBRE + " PRODUCTO INSERTADO CON EXITO";
            }
            else
            {
                Message = almacen.NOMBRE + " EL PRODUCTO NO PUDO SER INSERTADO";
            }
            con.Close();
            return Message;
        }

        public string EliminarAlmacen(int id)
        {
            string Message = "";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-67GERHD\\SQLEXPRESS;Initial Catalog=vet;User ID=sa;Password=123456");

            SqlCommand cmd = new SqlCommand("delete from Almace where IDITEM= '" + id + "'", con);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                Message = "ELIMINADO CON EXITO";
            }
            else
            {
                Message = "NO ELIMINADO";
            }
            con.Close();
            return Message;
        }

        public List<Almacen> ListarAlmacen()
        {

            List<Almacen> ListAlma = new List<Almacen>();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-67GERHD\\SQLEXPRESS;Initial Catalog=vet;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand("select * from ALMACEN", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListAlma.Add(new Almacen(int.Parse(reader[0].ToString()),
                                            reader[1].ToString(),
                                            reader[2].ToString(),
                                            double.Parse(reader[3].ToString()),
                                            int.Parse(reader[4].ToString()),
                                            int.Parse(reader[5].ToString())));
            }
            con.Close();
            return ListAlma;
        }
    }
}
