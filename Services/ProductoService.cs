using Microsoft.EntityFrameworkCore;
using ServicioClientesSOA.Data;
using ServicioClientesSOA.Models;
using System.Collections.Generic;
using System.Linq;

namespace ServicioClientesSOA.Services
{
    public class ProductoService : IProductoService
    {
        private readonly AppDbContext _context;

        public ProductoService(AppDbContext context)
        {
            _context = context;
        }

        public List<Producto> ListarProductos()
        {
            return _context.Productos
                .Include(p => p.TipoProducto)
                .ToList();
        }

        public Producto ObtenerProductoPorId(int id)
        {
            return _context.Productos
                .Include(p => p.TipoProducto)
                .FirstOrDefault(p => p.Id == id) ?? new Producto();
        }

        public void InsertarProducto(Producto producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
        }

        public void ActualizarProducto(Producto producto)
        {
            var existente = _context.Productos.Find(producto.Id);
            if (existente != null)
            {
                existente.IdTipo = producto.IdTipo;
                existente.Descripcion = producto.Descripcion;
                existente.Valor = producto.Valor;
                existente.Costo = producto.Costo;
                _context.SaveChanges();
            }
        }

        public void EliminarProducto(int id)
        {
            var producto = _context.Productos.Find(id);
            if (producto != null)
            {
                _context.Productos.Remove(producto);
                _context.SaveChanges();
            }
        }
    }
}
