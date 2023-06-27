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
        public int IDMOTIVO;
        [DataMember]
        public string DESCRIPCION;

        public Motivo(int iDMOTIVO, string dESCRIPCION)
        {
            IDMOTIVO = iDMOTIVO;
            DESCRIPCION = dESCRIPCION;
        }
    }
}