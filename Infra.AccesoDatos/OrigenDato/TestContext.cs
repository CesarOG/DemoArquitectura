using Dominio.Entidades.Model;
using Microsoft.EntityFrameworkCore;

namespace Infra.AccesoDatos.OrigenDato
{
    public class TestContext : DbContext
    {     
        public TestContext(DbContextOptions<TestContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Producto> Producto { get; set; }

    }
}
