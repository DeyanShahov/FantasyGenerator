using FantasyGenerator.Infrastructure.Data.Content;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FantasyGenerator.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder
                .Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            builder
                .Entity<Race>()
                .HasOne(r => r.Author)
                .WithMany(a => a.Races)
                .HasForeignKey(r => r.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Feat>()
                .HasOne(f => f.Author)
                .WithMany(a => a.Feats)
                .HasForeignKey(f => f.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Skill>()
                .HasOne(f => f.Author)
                .WithMany(a => a.Skills)
                .HasForeignKey(f => f.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);

        }

        public DbSet<Race> Races { get; init; }

        public DbSet<Feat> Feats { get; init; }

        public DbSet<Skill> Skills { get; init; }
    }
}