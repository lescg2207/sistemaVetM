using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace wcfVeterinaria
{
    [DataContract]
    public class Users
    {
        [DataMember]
        public int IDUSUARIO;
        [DataMember]
        public int TIPOUSU;
        [DataMember]
        public string USUARIO;
        [DataMember]
        public string CONTRASEÑA;
        [DataMember]
        public string NOMBRECOMPLETO;
        [DataMember]
        public string CORREO;
        [DataMember]
        public string CELULAR;
        [DataMember]
        public int ESTADOUSUARIO;

        public Users(int iDUSUARIO, int tIPOUSU, string uSUARIO, string cONTRASEÑA, string nOMBRECOMPLETO, string cORREO, string cELULAR, int eSTADOUSUARIO)
        {
            IDUSUARIO = iDUSUARIO;
            TIPOUSU = tIPOUSU;
            USUARIO = uSUARIO;
            CONTRASEÑA = cONTRASEÑA;
            NOMBRECOMPLETO = nOMBRECOMPLETO;
            CORREO = cORREO;
            CELULAR = cELULAR;
            ESTADOUSUARIO = eSTADOUSUARIO;
        }

        public Users(int tIPOUSU, string uSUARIO, string cONTRASEÑA, string nOMBRECOMPLETO, string cORREO, string cELULAR, int eSTADOUSUARIO)
        {
            TIPOUSU = tIPOUSU;
            USUARIO = uSUARIO;
            CONTRASEÑA = cONTRASEÑA;
            NOMBRECOMPLETO = nOMBRECOMPLETO;
            CORREO = cORREO;
            CELULAR = cELULAR;
            ESTADOUSUARIO = eSTADOUSUARIO;
        }

        public Users()
        {
        }
    }
}