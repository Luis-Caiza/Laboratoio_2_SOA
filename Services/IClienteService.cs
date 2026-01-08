using CoreWCF;
using ServicioClientesSOA.Models;
using System.Collections.Generic;

namespace ServicioClientesSOA.Services
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        List<Cliente> ListarClientes();

        [OperationContract]
        void InsertarCliente(Cliente cliente);
    }
}
