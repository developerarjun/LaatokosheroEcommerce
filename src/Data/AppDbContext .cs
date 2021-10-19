using LaatokosheroBackEnd.src.Model.Profile;
using Microsoft.EntityFrameworkCore;

namespace LaatokosheroBackEnd.src.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {
            
        }
         public DbSet<AdminProfile> AdminProfiles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminProfile>().Property(p => p.logoImage)
                .HasColumnType("Blob");
        }
    }
}