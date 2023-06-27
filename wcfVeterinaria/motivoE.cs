using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace wcfVeterinaria
{
    public class motivoE
    {
        [DataMember]
        public int IDMOTIVO;
        [DataMember]
        public string DESCRIPCION;

        public motivoE(int iDMOTIVO, string dESCRIPCION)
        {
            IDMOTIVO = iDMOTIVO;
            DESCRIPCION = dESCRIPCION;
        }
    }
}