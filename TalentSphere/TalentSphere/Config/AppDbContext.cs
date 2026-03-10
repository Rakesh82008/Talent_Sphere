using Microsoft.EntityFrameworkCore;

using TalentSphere.Models.User;
namespace TalentSphere.Config
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<User>Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                // default true for IsActive when inserting new user rows
                entity.Property(e => e.IsActive)
                      .HasDefaultValue(true)
                      .ValueGeneratedOnAdd();

                // default UTC datetime for CreatedAt and LastUpdatedAt
                // Use SYSUTCDATETIME() for higher precision UTC datetime on SQL Server
                entity.Property(e => e.CreatedAt)
                      .HasDefaultValueSql("SYSUTCDATETIME()")
                      .ValueGeneratedOnAdd();

                entity.Property(e => e.LastUpdatedAt)
                      .HasDefaultValueSql("SYSUTCDATETIME()")
                      .ValueGeneratedOnAdd();
            });
        }

    }
}
