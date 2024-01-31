using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RBS.Db.Entities;

namespace RBS.Db.Context
{
    public class RbsContext : IdentityDbContext<IdentityUser>
    {
        public RbsContext(DbContextOptions<RbsContext> options) : base(options)
        {
            
        }

        public DbSet<Space> Spaces { get; set; }

        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RbsContext).Assembly);

            modelBuilder.Entity<Location>(entity =>
            {
                entity.Property(e => e.Coordinates).HasColumnType("geography");
            });
        }
    }
}
