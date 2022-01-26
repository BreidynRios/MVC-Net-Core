using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedido");

            builder.HasKey(p => p.IdOrden);

            builder.Property(p => p.IdOrden)
                .HasColumnName("IdOrden");

            builder.Property(p => p.CodigoCliente)
                .HasColumnName("CodigoCliente");

            builder.Property(p => p.Fecha)
                .HasColumnName("Fecha")
                .HasColumnType("datetime");

            builder.Property(p => p.Total)
                .HasColumnName("Total");

            builder.HasOne(c => c.Cliente)
                .WithMany(p => p.Pedidos)
                .HasForeignKey(c => c.CodigoCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pedido_Cliente");
        }
    }
}
