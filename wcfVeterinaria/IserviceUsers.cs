using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcfVeterinaria
{
    
    [ServiceContract]
    public interface IserviceUsers
    {
        [OperationContract]
        string AgregarUsuario(Users usuario);

        [OperationContract]
        string EliminarUsario(int id);
        [OperationContract]
        string ActualizarUsuario(Users usuario, int id);

        [OperationContract]
        Users validarLogin(string usuario, string contra);

        [OperationContract]
        Users BuscarUsuario(int idusuario);

        [OperationContract]
        List<tipoUsu> listarTipo();

        [OperationContract]
        List<estadoUsu> listarEstado();

        [OperationContract]
        List<motivoE> listarMotivo();
    }
}
