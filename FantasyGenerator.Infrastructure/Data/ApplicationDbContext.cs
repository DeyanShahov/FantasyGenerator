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
                .HasOne(s => s.Author)
                .WithMany(a => a.Skills)
                .HasForeignKey(s => s.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<NpcCategoryName>()
                .HasOne(n => n.Author)
                .WithMany(a => a.NpcCategoryNames)
                .HasForeignKey(n => n.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<NpcName>()
                .HasOne(n => n.Category)
                .WithMany(c => c.NpcNames)
                .HasForeignKey(n => n.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
               .Entity<NpcName>()
               .HasOne(n => n.Author)
               .WithMany(a => a.NpcNames)
               .HasForeignKey(n => n.AuthorId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
               .Entity<NpcName>()
               .HasOne(n => n.Race)
               .WithMany(r => r.npcNames)
               .HasForeignKey(n => n.RaceId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<ProfessionCategory>()
                .HasOne(p => p.Author)
                .WithMany(a => a.ProfessionCategories)
                .HasForeignKey(p => p.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Profession>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Professions)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
               .Entity<Profession>()
               .HasOne(p => p.Author)
               .WithMany(a => a.Professions)
               .HasForeignKey(p => p.AuthorId)
               .OnDelete(DeleteBehavior.Restrict);

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
             .OnDelete(DeleteBehavior.Restrict);

            builder
           .Entity<Npc>()
           .HasOne(n => n.Author)
           .WithMany(a => a.Npcs)
           .HasForeignKey(n => n.AuthorId)
           .OnDelete(DeleteBehavior.Restrict);

        }

        public DbSet<Race> Races { get; init; }

        public DbSet<Feat> Feats { get; init; }

        public DbSet<Skill> Skills { get; init; }

        public DbSet<NpcCategoryName> NpcCategoryNames { get; init; }

        public DbSet<NpcName> NpcNames { get; init; }

        public DbSet<ProfessionCategory> ProfessionCategories { get; init; }

        public DbSet<Profession> Professions { get; init; }

        public DbSet<Npc> Npcs { get; init; }
    }
}