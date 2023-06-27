using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace wcfVeterinaria
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioAlmacen" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioAlmacen
    {
        [OperationContract]
        string AgregarAlmacen(clsAlmacen almacen);

        [OperationContract]
        bool ElimnarAlmacen(clsAlmacen almacen);
        [OperationContract]
        string ActualizarAlmacen(clsAlmacen almacen);


        [OperationContract]
        DataSet ObtenerAlmacen();

        [OperationContract]
        DataSet FetchUpdatedRecords(clsAlmacen almacen);
    }
}
