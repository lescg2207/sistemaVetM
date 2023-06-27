using System.Runtime.Serialization;

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