using LaatokosheroBackEnd.src.Model.Profile;
using LaatokosheroBackEnd.src.Model.RolePermission;
using Microsoft.EntityFrameworkCore;

namespace LaatokosheroBackEnd.src.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {
            
        }
         public DbSet<AdminProfile> AdminProfiles { get; set; }
         public DbSet<AdminUser> AdminUsers {get;set;}
         public DbSet<Role> Roles {get;set;}
         public DbSet<UserRole> UserRoles {get;set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminProfile>().Property(p => p.logoImage)
                .HasColumnType("Blob");

            modelBuilder.Entity<AdminUser>(e => {
                e.HasIndex(a => a.UserName).IsUnique();
            });

            modelBuilder.Entity<Role>(e => {
                e.HasIndex(a => a.RoleName).IsUnique();
            });

            modelBuilder.Entity<UserRole>()
                .HasKey(t => new {t.UserId,t.RoleId});
        }
    }
}