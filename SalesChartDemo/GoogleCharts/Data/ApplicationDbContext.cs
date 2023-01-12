using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using SalesChartDemo.Entites;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace SalesChartDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Chart> Charts { get; set; }
        public DbSet<Options> Options { get; set; }
        public DbSet<DataNum> Data { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
       {

            modelBuilder.Entity<Chart>()
           .HasMany(b => b.Data)
           .WithOne();

            var chart = JsonConvert.DeserializeObject<Chart>(File.ReadAllText("./Data/seed/chart.json"));
            var options = JsonConvert.DeserializeObject<Options>(File.ReadAllText("./Data/seed/options.json"));
            var data = JsonConvert.DeserializeObject<IEnumerable<DataNum>>(File.ReadAllText("./Data/seed/data.json"));

            modelBuilder.Entity<Chart>().HasData(chart);
            modelBuilder.Entity<Options>().HasData(options);
            modelBuilder.Entity<DataNum>().HasData(data);

        }

    }
}
