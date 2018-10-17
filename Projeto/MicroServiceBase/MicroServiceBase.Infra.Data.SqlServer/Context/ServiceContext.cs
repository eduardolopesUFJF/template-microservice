using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MicroServiceBase.Domain.UsuarioRoot;
using MicroServiceBase.Infra.Data.SqlServer.Mappings;
using System.IO;

namespace MicroServiceBase.Infra.Data.SqlServer.Context
{
    public class ServiceContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}