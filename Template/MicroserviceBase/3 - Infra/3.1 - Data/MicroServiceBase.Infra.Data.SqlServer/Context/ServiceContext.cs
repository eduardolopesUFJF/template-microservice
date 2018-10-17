using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using $saferootprojectname$.Domain.UsuarioRoot;
using $safeprojectname$.Mappings;
using System.IO;

namespace $safeprojectname$.Context
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