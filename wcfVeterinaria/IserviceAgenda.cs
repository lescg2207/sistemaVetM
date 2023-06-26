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
   
    [ServiceContract]
    public interface IserviceAgenda
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "ObtenerEventos")]
        List<Evento> ObtenerEventos();
    }
}
