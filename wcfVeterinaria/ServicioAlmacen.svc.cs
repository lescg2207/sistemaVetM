using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcfVeterinaria
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioAlmacen" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioAlmacen.svc o ServicioAlmacen.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioAlmacen : IServicioAlmacen
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8RD4SAJ\\SQLEXPRESS;Database=vet ;integrated Security=true;");

        public string ActualizarAlmacen(clsAlmacen almacen)
        {
            string Status;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("update ALMACEN set NOMBRE=@nombre,PRESENTACION=@presentacion,PRECIO=@precio, STOCK=@stock,ESTADO=@estado where IDITEM=@idtem", con);
            cmd.Parameters.AddWithValue("@idtem", almacen.IDITEM);
            cmd.Parameters.AddWithValue("@nombre", almacen.NOMBRE);
            cmd.Parameters.AddWithValue("@presentacion", almacen.PRESENTACION);
            cmd.Parameters.AddWithValue("@precio", almacen.PRECIO);
            cmd.Parameters.AddWithValue("@stock", almacen.STOCK);
            cmd.Parameters.AddWithValue("@estado", almacen.ESTADO);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Status = "SE ACTUALIZO CON EXITO";
            }
            else
            {
                Status = "NO SE PUDO ACTUALIZAR";
            }
            con.Close();
            return Status;
        }

        public string AgregarAlmacen(clsAlmacen almacen)
        {
            string Message;

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
                Message = almacen.NOMBRE + " producto insertado con exito";
            }
            else
            {
                Message = almacen.NOMBRE + " El producto no se ha insertado";
            }
            con.Close();
            return Message;
        }

        public bool ElimnarAlmacen(clsAlmacen almacen)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("update ALMACEN set ESTADO = 2 where IDITEM = @iditem", con);

            cmd.Parameters.AddWithValue("@iditem", almacen.IDITEM);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public DataSet FetchUpdatedRecords(clsAlmacen almacen)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from ALMACEN where IDITEM=@iditem", con);
            cmd.Parameters.AddWithValue("@iditem", almacen.IDITEM);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;
        }

        public DataSet ObtenerAlmacen()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select * from ALMACEN where ESTADO=1", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;
        }
    }
}
