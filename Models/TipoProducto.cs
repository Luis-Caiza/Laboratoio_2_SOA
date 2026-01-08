using System.ComponentModel.DataAnnotations.Schema;

namespace ServicioClientesSOA.Models
{
    public class TipoProducto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Tipo { get; set; } = string.Empty;
    }
}
