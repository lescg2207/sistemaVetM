using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcfVeterinaria
{

    [ServiceContract]
    public interface IserviceAlmacen
    {
        [OperationContract]
        string AgregarAlmacen(Almacen almacen);
        [OperationContract]
        List<Almacen> ListarAlmacen();

        [OperationContract]
        string EliminarAlmacen(int id);
        [OperationContract]
        string ActualizarAlmacen(Almacen almacen, int id);
    }
}
