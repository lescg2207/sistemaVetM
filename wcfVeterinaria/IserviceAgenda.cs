using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Web;
using System.Web.Http;

namespace wcfVeterinaria
{
  
    [ServiceContract]
    public interface IserviceAgenda
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "ListadoAgenda")]
        List<viewAgenda> ListadoAgenda();



    }
}
