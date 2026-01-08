using CoreWCF;
using ServicioClientesSOA.Models;
using System.Collections.Generic;

namespace ServicioClientesSOA.Services
{
    [ServiceContract]
    public interface IProductoService
    {
        [OperationContract]
        List<Producto> ListarProductos();

        [OperationContract]
        Producto ObtenerProductoPorId(int id);

        [OperationContract]
        void InsertarProducto(Producto producto);

        [OperationContract]
        void ActualizarProducto(Producto producto);

        [OperationContract]
        void EliminarProducto(int id);
    }
}
