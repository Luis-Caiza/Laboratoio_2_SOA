using ServicioClientesSOA.Data;
using ServicioClientesSOA.Models;
using System.Collections.Generic;
using System.Linq;

namespace ServicioClientesSOA.Services
{
    public class ClienteService : IClienteService
    {
        private readonly AppDbContext _context;

        public ClienteService(AppDbContext context)
        {
            _context = context;
        }

        public List<Cliente> ListarClientes()
        {
            return _context.Clientes.ToList();
        }

        public void InsertarCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }
    }
}
