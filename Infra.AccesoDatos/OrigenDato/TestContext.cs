using Dominio.Entidades.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.AccesoDatos.OrigenDato
{
    public class TestContext : DbContext
    {
        //public TestContext()
        //{

        //}
        //public TestContext(DbContextOptions<TestContext> options) : base(options)
        //{
        //}
        private readonly string _connectionString;

        public TestContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        public DbSet<Cliente> Cliente { get; set; }

    }
}
