using System.Runtime.Serialization;

namespace ServicioClientesSOA.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public int IdTipo { get; set; }
        public string Descripcion { get; set; }
        public double Valor { get; set; }
        public double Costo { get; set; }

        // Relación con TipoProducto (ignorada en el contrato SOAP)
        [IgnoreDataMember]
        public TipoProducto TipoProducto { get; set; }
    }
}
