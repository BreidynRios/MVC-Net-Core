using Domain;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
    public class DBKaitsContext : DbContext
    {
        public DBKaitsContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<DetallePedido> DetallePedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
