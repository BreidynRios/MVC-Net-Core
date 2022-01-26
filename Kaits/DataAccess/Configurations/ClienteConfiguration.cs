using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(c => c.Codigo);

            builder.Property(c => c.Codigo)
                .HasColumnName("Codigo");

            builder.Property(c => c.Nombres)
                .HasColumnName("Nombres");

            builder.Property(c => c.ApellidoPaterno)
                .HasColumnName("ApellidoPaterno");

            builder.Property(c => c.ApellidoMaterno)
                .HasColumnName("ApellidoMaterno");
        }
    }
}
