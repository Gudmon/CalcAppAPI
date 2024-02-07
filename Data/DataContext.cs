using CalcAppAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace CalcAppAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }
        public DbSet<Machine> Machines { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Machine>().HasData(
                new Machine()
                {
                   Id = 1,
                   Name = "Test",
                   Price = "100"
                }
                );
            base.OnModelCreating(builder);
        }
    }
}
