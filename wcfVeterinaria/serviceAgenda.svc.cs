using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Script.Serialization;

namespace wcfVeterinaria
{

    public class serviceAgenda : IserviceAgenda
    {
        bdVetDataContext bdVet = new bdVetDataContext();

        public List<viewAgenda> ListadoAgenda()
        {
            var qry = from p in bdVet.AGENDA

                      select new viewAgenda
                      {

                          id = p.IDCITA,
                          title = p.DESCRIPCION,
                          start = p.FECHA.ToString(),
                          end = "2023-06-20",

                      };
            return qry.ToList();

        }
    }
    
}
