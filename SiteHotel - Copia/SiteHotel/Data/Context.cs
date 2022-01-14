using Microsoft.EntityFrameworkCore;
using SiteHotel.Models.Hotel.Entities;
using SiteHotel.Models.Usuario.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteHotel.Repository
{
    public class Context:DbContext
    {
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Apartamento> Apartamento { get; set; }
        public DbSet<Imagens> Imagens { get; set; }
        public DbSet<Reserva> Reserva { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Data Source=localhost; Initial Catalog= TesteGenerico; User ID=usuario1; password=senha123; Language=Portuguese; Trusted_Connection=True");
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Reserva>()
                .HasOne(r => r.Apartamento)
                .WithMany(a => a.Reserva)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder
                .Entity<Imagens>()
                .HasOne(i => i.Apartamento)
                .WithMany(a => a.Imagens)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder
                .Entity<Reserva>()
                .HasOne(r => r.Pessoa)
                .WithMany(p => p.Reserva)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder
                .Entity<Login>()
                .HasOne(l => l.Pessoa)
                .WithOne(p => p.Login)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder
                .Entity<Endereco>()
                .HasOne(e => e.Pessoa)
                .WithOne(p => p.Enderecos)
                .OnDelete(DeleteBehavior.ClientCascade);

        }
        
    }
}
