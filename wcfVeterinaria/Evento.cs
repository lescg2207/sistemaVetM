using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace wcfVeterinaria
{
    [DataContract]
    public class Evento
    {
        [DataMember]
        public string Titulo { get; set; }

        [DataMember]
        public DateTime FechaInicio { get; set; }

        [DataMember]
        public DateTime FechaFin { get; set; }

        [DataMember]
        public string Color { get; set; }
        [DataMember]
        public string Cliente { get; set; }
        [DataMember]
        public string Observacion { get; set;}
    }
}