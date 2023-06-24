using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Script.Services;

namespace wcfVeterinaria
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IserviceAgenda" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IserviceAgenda
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "ObtenerEventos")]
        List<Evento> ObtenerEventos();
    }
}
