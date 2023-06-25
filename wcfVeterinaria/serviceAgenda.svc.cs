using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcfVeterinaria
{
  
    public class serviceAgenda : IserviceAgenda
    {
        SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=vet;User ID=sa;Password=les123");
        public List<Evento> ObtenerEventos()
        {
            List<Evento> eventos = new List<Evento>();

            using (connection)
            {
                string query = "SELECT MOTIVO.DESCRIPCION, Agenda.FechaInicio, Agenda.FechaFin, Agenda.Color FROM  Agenda INNER JOIN MOTIVO ON Agenda.IDMOTIVO = MOTIVO.IDMOTIVO";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Evento evento = new Evento
                            {
                                Titulo = reader.GetString(0),
                                FechaInicio = reader.GetDateTime(1),
                                FechaFin = reader.GetDateTime(2),
                                Color = reader.GetString(3)
                            };

                            eventos.Add(evento);
                        }
                    }
                }
            }

            return eventos;
        }
    }
}
