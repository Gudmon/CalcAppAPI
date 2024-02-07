using CalcAppAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace CalcAppAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }
        public DbSet<Machine> Machines { get; set; }
        public DbSet<Crane> Cranes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Machine>()
                .HasMany(e => e.Cranes)
                .WithMany(e => e.Machines);

        }
    }
}
