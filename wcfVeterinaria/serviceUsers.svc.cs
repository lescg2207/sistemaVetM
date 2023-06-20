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

    public class serviceUsers : IserviceUsers
    {
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=vet;User ID=sa;Password=les123");
        public string ActualizarUsuario(Users usuario, int id)
        {
            string MENSAJE;
            SqlCommand cmd = new SqlCommand("update USUARIOS set TIPOUSU=@1,USUARIO=@2,CONTRASEÑA=@3,NOMBRECOMPLETO=@4,CORREO=@5,CELULAR=@6 where idusuario=@7", con);
            cmd.Parameters.AddWithValue("@1", usuario.TIPOUSU);
            cmd.Parameters.AddWithValue("@2", usuario.USUARIO);
            cmd.Parameters.AddWithValue("@3", usuario.CONTRASEÑA);
            cmd.Parameters.AddWithValue("@4", usuario.NOMBRECOMPLETO);
            cmd.Parameters.AddWithValue("@5", usuario.CORREO);
            cmd.Parameters.AddWithValue("@6", usuario.CELULAR);
            cmd.Parameters.AddWithValue("@7", id);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                MENSAJE = " USUARIO MODIFICADO CON EXITO";
            }
            else
            {
                MENSAJE = " USUARIO NO MODIFICADO CON EXITO";
            }
            con.Close();
            return MENSAJE;
        }

        public string AgregarUsuario(Users usuario)
        {
            string MENSAJE;
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into USUARIOS(TIPOUSU,USUARIO,CONTRASEÑA,NOMBRECOMPLETO,CORREO,ESTADOUSUARIO,CELULAR) values(@1,@2,@3,@4,@5,@6,@7)", con);
            cmd.Parameters.AddWithValue("@1", usuario.TIPOUSU);
            cmd.Parameters.AddWithValue("@2", usuario.USUARIO);
            cmd.Parameters.AddWithValue("@3", usuario.CONTRASEÑA);
            cmd.Parameters.AddWithValue("@4", usuario.NOMBRECOMPLETO);
            cmd.Parameters.AddWithValue("@5", usuario.CORREO);
            cmd.Parameters.AddWithValue("@6", usuario.ESTADOUSUARIO);
            cmd.Parameters.AddWithValue("@7", usuario.CELULAR);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                MENSAJE = usuario.NOMBRECOMPLETO + " INSERTADO CON EXITO";
            }
            else
            {
                MENSAJE = " NO SE PUDO INSERTAR CON EXITO";
            }
            con.Close();
            return MENSAJE;
        }

        public Users BuscarUsuario(string idusuario)
        {
            Users USUARIO = new Users();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Usuarios Where idusuario = @id", con);
            cmd.Parameters.AddWithValue("@id", idusuario);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                USUARIO.IDUSUARIO = int.Parse(reader[0].ToString());
                USUARIO.TIPOUSU = int.Parse(reader[1].ToString());
                USUARIO.USUARIO = reader[2].ToString();
                USUARIO.CONTRASEÑA = reader[3].ToString();
                USUARIO.NOMBRECOMPLETO = reader[4].ToString();
                USUARIO.CORREO = reader[5].ToString();
                USUARIO.ESTADOUSUARIO = int.Parse(reader[6].ToString());
                USUARIO.CELULAR = reader[7].ToString();
            }
            {
            }
            return USUARIO;
        }

        public string EliminarUsario(int id)
        {
            string MENSAJE;

            SqlCommand cmd = new SqlCommand("UPDATE USUARIOS SET ESTADOUSUARIO=0 WHERE IDUSUARIO=" + id, con);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MENSAJE = "ELIMINADO CON EXITO";
            }
            else
            {
                MENSAJE = "NO SE PUDO ELIMINAR CON EXITO";
            }
            con.Close();
            return MENSAJE;
        }

        public List<estadoUsu> listarEstado()
        {
            List<estadoUsu> lista = new List<estadoUsu>();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spListarEstado";
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new estadoUsu(int.Parse(reader[0].ToString()), reader[1].ToString()));
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Dispose();
            }

            return lista;
        }

        public List<tipoUsu> listarTipo()
        {
            List<tipoUsu> lista = new List<tipoUsu>();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spListarTipo";
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new tipoUsu(int.Parse(reader[0].ToString()), reader[1].ToString()));
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Dispose();
            }

            return lista;
        }

        public Users validarLogin(string usuario, string contra)
        {
            Users USUARIO = new Users();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT USUARIOS.IDUSUARIO,TIPOUSU.tipo, USUARIOS.Usuario, USUARIOS.CONTRASEÑA, USUARIOS.NOMBRECOMPLETO,USUARIOS.CORREO,estaUsu.Estado,USUARIOS.CELULAR FROM USUARIOS INNER JOIN tipoUsu ON USUARIOS.TIPOUSU = tipoUsu.idTipo inner join estaUsu on USUARIOS.ESTADOUSUARIO=estaUsu.idEstado Where usuario = @user and contraseña = @pass", con);
            cmd.Parameters.AddWithValue("@user", usuario);
            cmd.Parameters.AddWithValue("@pass", contra);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                USUARIO.IDUSUARIO = int.Parse(reader[0].ToString());
                USUARIO.TIPO = reader[1].ToString();
                USUARIO.USUARIO = reader[2].ToString();
                USUARIO.CONTRASEÑA = reader[3].ToString();
                USUARIO.NOMBRECOMPLETO = reader[4].ToString();
                USUARIO.CORREO = reader[5].ToString();
                USUARIO.ESTADO = reader[6].ToString();
                USUARIO.CELULAR = reader[7].ToString();
            }
            
            return USUARIO;
        }
    }
}
