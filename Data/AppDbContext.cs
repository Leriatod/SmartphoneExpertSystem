using Microsoft.EntityFrameworkCore;
using PhoneExp.Data.Models;

namespace PhoneExp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public DbSet<FeatureType> FeatureTypes { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<PhoneFeature> PhoneFeatures { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {       
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PhoneFeature>().HasKey(pf => 
                new { pf.PhoneId, pf.FeatureId });
        }
    }
}