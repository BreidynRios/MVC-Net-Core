using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class DetallePedidoConfiguration : IEntityTypeConfiguration<DetallePedido>
    {
        public void Configure(EntityTypeBuilder<DetallePedido> builder)
        {
            builder.ToTable("DetallePedido");

            builder.HasKey(dp => dp.Id);

            builder.Property(dp => dp.Id)
                .HasColumnName("IdDetalle");

            builder.Property(dp => dp.IdOrden)
                .HasColumnName("IdOrden");

            builder.Property(dp => dp.CodigoProducto)
                .HasColumnName("CodigoProducto");

            builder.Property(dp => dp.Descripcion)
                .HasColumnName("Descripcion");

            builder.Property(dp => dp.Cantidad)
                .HasColumnName("Cantidad");

            builder.Property(dp => dp.PrecioUnitario)
                .HasColumnName("PrecioUnitario");

            builder.Property(dp => dp.SubTotal)
                .HasColumnName("SubTotal");

            builder.HasOne(p => p.Producto)
                .WithMany(dp => dp.DetallePedidos)
                .HasForeignKey(p => p.CodigoProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetallePedido_Producto");

            builder.HasOne(p => p.Pedido)
                .WithMany(dp => dp.DetallePedidos)
                .HasForeignKey(p => p.IdOrden)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetallePedido_Orden");
        }
    }
}
