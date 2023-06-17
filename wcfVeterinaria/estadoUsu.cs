using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace wcfVeterinaria
{
    [DataContract]
    public class estadoUsu
    {
        [DataMember]
        public int IDESTADO;
        [DataMember]
        public string ESTADO;

        public estadoUsu(int iDESTADO, string eSTADO)
        {
            IDESTADO = iDESTADO;
            ESTADO = eSTADO;
        }
    }
}