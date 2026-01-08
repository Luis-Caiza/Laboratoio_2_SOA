using CoreWCF;
using ServicioClientesSOA.Models;
using System.Collections.Generic;

namespace ServicioClientesSOA.Services
{
    [ServiceContract(Namespace = "http://tempuri.org/")]
    public interface ITipoProductoService
    {
        [OperationContract(Action = "http://tempuri.org/ITipoProductoService/ListarTipoProductos", ReplyAction = "http://tempuri.org/ITipoProductoService/ListarTipoProductosResponse")]
        List<TipoProducto> ListarTipoProductos();

        [OperationContract(Action = "http://tempuri.org/ITipoProductoService/ObtenerTipoProductoPorId", ReplyAction = "http://tempuri.org/ITipoProductoService/ObtenerTipoProductoPorIdResponse")]
        TipoProducto ObtenerTipoProductoPorId(int id);

        [OperationContract(Action = "http://tempuri.org/ITipoProductoService/InsertarTipoProducto", ReplyAction = "http://tempuri.org/ITipoProductoService/InsertarTipoProductoResponse")]
        void InsertarTipoProducto(TipoProducto tipoProducto);

        [OperationContract(Action = "http://tempuri.org/ITipoProductoService/ActualizarTipoProducto", ReplyAction = "http://tempuri.org/ITipoProductoService/ActualizarTipoProductoResponse")]
        void ActualizarTipoProducto(TipoProducto tipoProducto);

        [OperationContract(Action = "http://tempuri.org/ITipoProductoService/EliminarTipoProducto", ReplyAction = "http://tempuri.org/ITipoProductoService/EliminarTipoProductoResponse")]
        void EliminarTipoProducto(int id);
    }
}
