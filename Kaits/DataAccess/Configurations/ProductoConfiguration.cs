using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable("Producto");

            builder.HasKey(c => c.Codigo);

            builder.Property(c => c.Codigo)
                .HasColumnName("Codigo");

            builder.Property(c => c.Descripcion)
                .HasColumnName("Descripcion");
        }
    }
}
