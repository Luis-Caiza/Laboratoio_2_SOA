using Microsoft.EntityFrameworkCore;
using ServicioClientesSOA.Models;

namespace ServicioClientesSOA.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<TipoProducto> TipoProductos { get; set; }
        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("clientes");
            
            modelBuilder.Entity<TipoProducto>().ToTable("tipo_producto");
            
            modelBuilder.Entity<Producto>(entity =>
            {
                entity.ToTable("producto");
                entity.HasOne(p => p.TipoProducto)
                      .WithMany()
                      .HasForeignKey(p => p.IdTipo)
                      .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
