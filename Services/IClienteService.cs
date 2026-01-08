using CoreWCF;
using ServicioClientesSOA.Models;
using System.Collections.Generic;

namespace ServicioClientesSOA.Services
{
    [ServiceContract(Namespace = "http://tempuri.org/")]
    public interface IClienteService
    {
        [OperationContract(Action = "http://tempuri.org/IClienteService/ListarClientes", ReplyAction = "http://tempuri.org/IClienteService/ListarClientesResponse")]
        List<Cliente> ListarClientes();

        [OperationContract(Action = "http://tempuri.org/IClienteService/InsertarCliente", ReplyAction = "http://tempuri.org/IClienteService/InsertarClienteResponse")]
        void InsertarCliente(Cliente cliente);
    }
}
