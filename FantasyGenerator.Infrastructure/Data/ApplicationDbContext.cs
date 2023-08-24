using FantasyGenerator.Infrastructure.Data.Content;
using FantasyGenerator.Infrastructure.Data.JsonModels;
using FantasyGenerator.Infrastructure.Data.Models;
using FantasyGenerator.Infrastructure.Data.Modles;
using FantasyGenerator.Infrastructure.InitialSeed;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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

            builder.ApplyConfiguration(new IdentityRoleConfiguration());
            builder.ApplyConfiguration(new IdentityUserConfiguration());

            builder.Entity<IdentityUserRole<string>>()
                .HasData(new IdentityUserRole<string>
                {
                    UserId = DataConstants.DefaultUser.UserId,
                    RoleId = DataConstants.DefaultUserRole.RoleId
                });


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


            builder
                //.ApplyConfiguration(new InitialDataConfiguration<NpcName>(@"InitialSeed/NpcNames.json"))
                .ApplyConfiguration(new InitialDataConfiguration<NpcName>(@"InitialSeed/HumanNpcNames.json"));
                //.ApplyConfiguration(new InitialDataConfiguration<NpcName>(@"InitialSeed/HumanNpcNames.json"));
        }

        public DbSet<Npc> Npcs { get; set; }

        public DbSet<Race> Races { get; set; }

        public DbSet<Profession> Professions { get; set;}

        public DbSet<NpcName> NpcsName { get; set; }

        public DbSet<NpcCategoryName> NpcsCategoryName { get; set;}
    }


    internal class IdentityRoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            var adminSeedRole = new IdentityRole
            {
                Id = DataConstants.DefaultUserRole.RoleId,
                Name = "DefaultUser",
                NormalizedName = "DefaultUser".ToUpper(),
                ConcurrencyStamp = DataConstants.DefaultUserRole.ConcurrencyStamp
            };

            builder.HasData(adminSeedRole);
        }

    }

    internal class IdentityUserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            var defaultSeederUser = new IdentityUser
            {
                Id = DataConstants.DefaultUser.UserId,
                UserName = "BaseUser",
                NormalizedUserName = "BaseUser".ToUpper(),
                Email = "baseuser@baseuser.com",
                NormalizedEmail = "baseuser@baseuser.com".ToUpper(),
                EmailConfirmed = true,
                PasswordHash = "AQAAAAEAACcQAAAAEKTaDGVGMc4iTM0t93yYVAaQPJyV/157OuV3+Pf2AJCodBSQl9+zLTdK76fKVlT9WQ==",
                SecurityStamp = null,
                ConcurrencyStamp = DataConstants.DefaultUser.ConcurrencyStamp,
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0
            };

            builder.HasData(defaultSeederUser);
        }
    }
}