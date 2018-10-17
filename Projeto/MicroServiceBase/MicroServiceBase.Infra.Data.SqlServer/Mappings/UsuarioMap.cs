using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MicroServiceBase.Domain.UsuarioRoot;

namespace MicroServiceBase.Infra.Data.SqlServer.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.Property(p => p.Email)
                .HasColumnType("varchar(100)")
                .IsRequired(true);

            builder.Property(p => p.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired(true);
        }
    }
}
