using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SalesChartDemo.Entites;
using System.Collections.Generic;
using System.IO;

namespace SalesChartDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Sale> Sales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var sales = JsonConvert.DeserializeObject<IEnumerable<Sale>>(File.ReadAllText("./Data/seed/sales.json"));

            modelBuilder.Entity<Sale>().HasData(sales);
        }

    }
}
