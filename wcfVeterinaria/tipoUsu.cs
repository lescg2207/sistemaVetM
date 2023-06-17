using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace wcfVeterinaria
{
    [DataContract]
    public class tipoUsu
    {
        [DataMember]
        public int IDTIPO;
        [DataMember]
        public string TIPOUSU;

        public tipoUsu(int iDTIPO, string tIPOUSU)
        {
            IDTIPO = iDTIPO;
            TIPOUSU = tIPOUSU;
        }

        public tipoUsu()
        {
        }
    }
}