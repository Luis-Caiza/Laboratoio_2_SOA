using CoreWCF;
using ServicioClientesSOA.Models;
using System.Collections.Generic;

namespace ServicioClientesSOA.Services
{
    [ServiceContract(Namespace = "http://tempuri.org/")]
    public interface IProductoService
    {
        [OperationContract(Action = "http://tempuri.org/IProductoService/ListarProductos", ReplyAction = "http://tempuri.org/IProductoService/ListarProductosResponse")]
        List<Producto> ListarProductos();

        [OperationContract(Action = "http://tempuri.org/IProductoService/ObtenerProductoPorId", ReplyAction = "http://tempuri.org/IProductoService/ObtenerProductoPorIdResponse")]
        Producto ObtenerProductoPorId(int id);

        [OperationContract(Action = "http://tempuri.org/IProductoService/InsertarProducto", ReplyAction = "http://tempuri.org/IProductoService/InsertarProductoResponse")]
        void InsertarProducto(Producto producto);

        [OperationContract(Action = "http://tempuri.org/IProductoService/ActualizarProducto", ReplyAction = "http://tempuri.org/IProductoService/ActualizarProductoResponse")]
        void ActualizarProducto(Producto producto);

        [OperationContract(Action = "http://tempuri.org/IProductoService/EliminarProducto", ReplyAction = "http://tempuri.org/IProductoService/EliminarProductoResponse")]
        void EliminarProducto(int id);
    }
}
