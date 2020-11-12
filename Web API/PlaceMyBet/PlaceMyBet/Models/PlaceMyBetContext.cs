using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class PlaceMyBetContext:DbContext
    {

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Apuesta> Apuestas { get; set; }
        public DbSet<Mercado> Mercados { get; set; }
        public DbSet<Evento> Eventos { get; set; }

        public PlaceMyBetContext()
        { 
        }

        public PlaceMyBetContext(DbContextOptions options) 
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;Port=3306;Database=PlaceMyBet2;Uid=root;password=");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Usuario>().HasData(new Usuario("adbaro@gmail.com", "Adrian", "Ballesteros", 20));
            modelbuilder.Entity<Usuario>().HasData(new Usuario("sami@gmail.com", "Sami", "Martinez", 18));
            modelbuilder.Entity<Evento>().HasData(new Evento(1,"Valencia","Espanyol","2020-09-20"));
            modelbuilder.Entity<Evento>().HasData(new Evento(2, "Barcelona", "Madrid", "2020-09-19"));
            modelbuilder.Entity<Mercado>().HasData(new Mercado(1, 1.1, 7.12, 650, 100, 2.5, 1));
            modelbuilder.Entity<Mercado>().HasData(new Mercado(2, 2.8, 1.2, 100, 50, 1.5, 1));
            modelbuilder.Entity<Apuesta>().HasData(new Apuesta(1, 2.5, 1.89, 100, "2020-09-18", 1, "adbaro@gmail.com", "over"));
            modelbuilder.Entity<Apuesta>().HasData(new Apuesta(2, 3.5, 1.3, 200, "2020-09-18", 2, "sami@gmail.com", "under"));
        }
    }
}