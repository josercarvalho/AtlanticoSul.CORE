using AtlanticoSul.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace AtlanticoSul.Infra.Data
{
    public class AtlanticoSulDbContext : DbContext
    {
        public AtlanticoSulDbContext(DbContextOptions<AtlanticoSulDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public AtlanticoSulDbContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Pais> Pais { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Boletos> Boletos { get; set; }
        public DbSet<ClienteCondominio> ClienteCondominios { get; set; }
        public DbSet<ClienteDados> ClienteDados { get; set; }
        public DbSet<Veiculos> ClienteVeiculos { get; set; }
        public DbSet<Condominio> Condominios { get; set; }
        public DbSet<Funcionarios> FuncUnidades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pais>().ToTable("Pais");
            modelBuilder.Entity<Estado>().ToTable("Estado");
            modelBuilder.Entity<Cidade>().ToTable("Cidade");
            modelBuilder.Entity<Boletos>().ToTable("Boletos");
            modelBuilder.Entity<Boletos>().ToTable("ClienteBoletos");
            modelBuilder.Entity<ClienteDados>().ToTable("ClienteDados");
            modelBuilder.Entity<Veiculos>().ToTable("ClienteVeiculos");
            modelBuilder.Entity<Condominio>().ToTable("Condominios");
            modelBuilder.Entity<Funcionarios>().ToTable("Funcionarios");
            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    var config = new ConfigurationBuilder()
        //       .SetBasePath(Directory.GetCurrentDirectory())
        //       .AddJsonFile("appsettings.json")
        //       .Build();

        //    optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        //}
    }
}
