using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace wcfVeterinaria
{
    public class Almacen
    {
        [DataMember]
        public int IDITEM;
        [DataMember]
        public string NOMBRE;
        [DataMember]
        public string PRESENTACION;
        [DataMember]
        public double PRECIO;
        [DataMember]
        public int STOCK;
        [DataMember]
        public int ESTADO;

        public Almacen(int iDITEM, string nOMBRE, string pRESENTACION, double pRECIO, int sTOCK, int eSTADO)
        {
            IDITEM = iDITEM;
            NOMBRE = nOMBRE;
            PRESENTACION = pRESENTACION;
            PRECIO = pRECIO;
            STOCK = sTOCK;
            ESTADO = eSTADO;
        }
    }
}