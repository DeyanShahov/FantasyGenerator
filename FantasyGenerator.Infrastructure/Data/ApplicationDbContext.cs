using FantasyGenerator.Infrastructure.Data.Content;
using FantasyGenerator.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FantasyGenerator.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder
                .Entity<Npc>()
                .HasOne(n => n.Race)
                .WithMany(r => r.Npcs)
                .HasForeignKey(n => n.RaceId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Npc>()
                .HasOne(n => n.Profession)
                .WithMany(p => p.Npcs)
                .HasForeignKey(n => n.ProfessionId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);
        }

        public DbSet<Npc> Npcs { get; set; }

        public DbSet<Race> Races { get; set; }

        public DbSet<Profession> Professions { get; set;}
    }
}