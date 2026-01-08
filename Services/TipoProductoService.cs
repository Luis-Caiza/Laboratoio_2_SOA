using ServicioClientesSOA.Data;
using ServicioClientesSOA.Models;
using System.Collections.Generic;
using System.Linq;

namespace ServicioClientesSOA.Services
{
    public class TipoProductoService : ITipoProductoService
    {
        private readonly AppDbContext _context;

        public TipoProductoService(AppDbContext context)
        {
            _context = context;
        }

        public List<TipoProducto> ListarTipoProductos()
        {
            return _context.TipoProductos.ToList();
        }

        public TipoProducto ObtenerTipoProductoPorId(int id)
        {
            return _context.TipoProductos.Find(id) ?? new TipoProducto();
        }

        public void InsertarTipoProducto(TipoProducto tipoProducto)
        {
            _context.TipoProductos.Add(tipoProducto);
            _context.SaveChanges();
        }

        public void ActualizarTipoProducto(TipoProducto tipoProducto)
        {
            var existente = _context.TipoProductos.Find(tipoProducto.Id);
            if (existente != null)
            {
                existente.Tipo = tipoProducto.Tipo;
                _context.SaveChanges();
            }
        }

        public void EliminarTipoProducto(int id)
        {
            var tipoProducto = _context.TipoProductos.Find(id);
            if (tipoProducto != null)
            {
                _context.TipoProductos.Remove(tipoProducto);
                _context.SaveChanges();
            }
        }
    }
}
