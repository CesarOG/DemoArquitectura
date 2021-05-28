using Dominio.Entidades.Model;
using Microsoft.EntityFrameworkCore;

namespace Infra.AccesoDatos.OrigenDato
{
    public class TestContext : DbContext
    {
        private readonly string _connectionString;

        public TestContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);                
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Producto> Producto { get; set; }

    }
}
