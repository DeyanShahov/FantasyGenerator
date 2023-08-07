using FantasyGenerator.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FantasyGenerator.Infrastructure.Data
{
    public class Npc
    {
        [Key]
        [MaxLength(DataConstants.GuidMaxLength)]
        public Guid Id { get; init; } = Guid.NewGuid();

        [Required]
        [MaxLength(DataConstants.Npc.FirstNameMaxLength)]
        public string FirstName { get; init; }

        [MaxLength(DataConstants.Npc.LastNameMaxLength)]
        public string? LastName { get; init; }

        [MaxLength(DataConstants.NpcName.NickNamePrefixMaxLength)]
        public string? NickNamePrefix { get; init; }

        [MaxLength(DataConstants.NpcName.NickNameSuffixMaxLength)]
        public string? NickNameSuffix { get; init; }

        public bool IsMale { get; init; } = true;


        [Required]
        [MaxLength(DataConstants.GuidMaxLength)]
        public Guid RaceId { get; init; }

        [MaxLength(DataConstants.Race.NameMaxLength)]
        [ForeignKey(nameof(RaceId))]
        public Race? Race { get; init; }


        [MaxLength(DataConstants.Profession.NameMaxLength)]
        public string? Profession { get; init; }


        [Required]
        [MaxLength(DataConstants.Profession.DescriptionMaxLength)]
        public string Description { get; init; }

        [Required]
        [MaxLength(450)]
        public string AuthorId { get; init; }

        [ForeignKey(nameof(AuthorId))]
        public IdentityUser Author { get; init; }

        public bool IsPublic { get; set; } = true;
    }
}
