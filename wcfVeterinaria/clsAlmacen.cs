using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace wcfVeterinaria
{
    [DataContract]
    public class clsAlmacen
    {
        int A_IDITEM;
        string A_NOMBRE = string.Empty;
        string A_PRESENTACION = string.Empty;
        double A_PRECIO;
        int A_STOCK;
        int A_ESTADO;

        [DataMember]
        public int IDITEM
        {
            get { return A_IDITEM; }
            set { A_IDITEM = value; }
        }
        [DataMember]
        public string NOMBRE
        {
            get { return A_NOMBRE; }
            set { A_NOMBRE = value; }
        }
        [DataMember]
        public string PRESENTACION
        {
            get { return A_PRESENTACION; }
            set { A_PRESENTACION = value; }
        }
        [DataMember]
        public double PRECIO
        {
            get { return A_PRECIO; }
            set { A_PRECIO = value; }
        }
        [DataMember]
        public int STOCK
        {
            get { return A_STOCK; }
            set { A_STOCK = value; }
        }
        [DataMember]
        public int ESTADO
        {
            get { return A_ESTADO; }
            set { A_ESTADO = value; }
        }

        public clsAlmacen(string nOMBRE, string pRESENTACION, double pRECIO, int sTOCK, int eSTADO)
        {

            NOMBRE = nOMBRE;
            PRESENTACION = pRESENTACION;
            PRECIO = pRECIO;
            STOCK = sTOCK;
            ESTADO = eSTADO;
        }

        public clsAlmacen(int iDITEM)
        {
            IDITEM = iDITEM;
        }
    }
}