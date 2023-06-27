using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace wcfVeterinaria
{
    [DataContract]
    public class Motivo
    {
        [DataMember]
        public int id;
        [DataMember]
        public string name;

        public Motivo(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}