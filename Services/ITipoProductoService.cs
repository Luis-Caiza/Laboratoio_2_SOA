using CoreWCF;
using ServicioClientesSOA.Models;
using System.Collections.Generic;

namespace ServicioClientesSOA.Services
{
    [ServiceContract]
    public interface ITipoProductoService
    {
        [OperationContract]
        List<TipoProducto> ListarTipoProductos();

        [OperationContract]
        TipoProducto ObtenerTipoProductoPorId(int id);

        [OperationContract]
        void InsertarTipoProducto(TipoProducto tipoProducto);

        [OperationContract]
        void ActualizarTipoProducto(TipoProducto tipoProducto);

        [OperationContract]
        void EliminarTipoProducto(int id);
    }
}
