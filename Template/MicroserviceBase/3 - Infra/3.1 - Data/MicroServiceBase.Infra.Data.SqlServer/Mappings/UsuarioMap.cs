using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using $saferootprojectname$.Domain.UsuarioRoot;

namespace $safeprojectname$.Mappings
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
