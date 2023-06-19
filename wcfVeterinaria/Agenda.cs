using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace wcfVeterinaria
{
    [DataContract]
    public class Agenda
    {
        [DataMember]
        public int IDCITA { get; set; }
        [DataMember]
        public string DESCRIPCION { get; set; }
        [DataMember]
        public string FECHA { get; set; }
        [DataMember]
        public string NOMBRECLIENTE { get; set; }
        [DataMember]
        public int ESTADO { get; set; }
        [DataMember]
        public int IDMOTIVO { get; set; }

    }
}