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
        public DbSet<Cemetery> Cemetaries { get; set; }
        public DbSet<Image> Images { get; set; }
        // ... other DbSets for your models ...

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=jabba;User Id=plotez;Password=plotez!;Database=plotez;");
        }

    }

}

