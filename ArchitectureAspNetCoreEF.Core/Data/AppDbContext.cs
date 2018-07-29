using ArchitectureAspNetCoreEF.Core.Domain.Entities;
using ArchitectureAspNetCoreEF.Core.Domain.Mappings;
using Microsoft.EntityFrameworkCore;

namespace ArchitectureAspNetCoreEF.Core.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        public DbSet<Carro> Carros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarroMap());
        }
    }
}