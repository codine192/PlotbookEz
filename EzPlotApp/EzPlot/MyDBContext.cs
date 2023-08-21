using EzPlot.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzPlot
{
    public class MYDBContext : DbContext
    {
        
        public DbSet<Plot> Plots { get; set; }
        public DbSet<PlotBook> PlotBooks { get; set; }
        public DbSet<Resident> Residents { get; set; }
        public DbSet<Cemetery> Cemeteries { get; set; }
        public DbSet<Marker> Markers { get; set; }
        // ... other DbSets for your models ...

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=jabba;User Id=plotez;Password=plotez!;Database=plotez;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Plot>()
                .HasOne(p => p.Marker)
                .WithOne(i => i.Plot)
                .HasForeignKey<Plot>(b => b.MarkerID);
            modelBuilder.Entity<Resident>()
                .HasOne(p => p.Plot)
                .WithOne(i => i.Resident)
                .HasForeignKey<Resident>(b => b.PlotID);
            modelBuilder.Entity<Cemetery>().HasData(
                new Cemetery { ID = 1, Name = "Miskellys Place" },
                     new Cemetery { ID = 2, Name = "Cemetery B"}
                    );

        }
    }



    

}

