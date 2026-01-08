using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace ServicioClientesSOA.Models
{
    public class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdTipo { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public double Valor { get; set; }
        public double Costo { get; set; }

        // Relación con TipoProducto (ignorada en el contrato SOAP)
        [IgnoreDataMember]
        public TipoProducto? TipoProducto { get; set; }
    }
}
