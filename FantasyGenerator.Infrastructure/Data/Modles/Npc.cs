using FantasyGenerator.Infrastructure.Data.Content;
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
        public string FirstName { get; set; }

        [MaxLength(DataConstants.Npc.LastNameMaxLength)]
        public string? LastName { get; set; }

        [MaxLength(DataConstants.NpcName.NickNamePrefixMaxLength)]
        public string? NickNamePrefix { get; set; }

        [MaxLength(DataConstants.NpcName.NickNameSuffixMaxLength)]
        public string? NickNameSuffix { get; set; }

        public bool IsMale { get; set; } = true;


        [Required]
        [MaxLength(DataConstants.GuidMaxLength)]
        public Guid RaceId { get; set; }

        [MaxLength(DataConstants.Race.NameMaxLength)]
        [ForeignKey(nameof(RaceId))]
        public Race? Race { get; set; }


        [MaxLength(DataConstants.GuidMaxLength)]
        public Guid ProfessionId { get; set; }

        [ForeignKey(nameof(ProfessionId))]
        public Profession Profession { get; set; }


        [Required]
        [MaxLength(DataConstants.DescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        [MaxLength(450)]
        public string AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public IdentityUser Author { get; set; }

        public bool IsPublic { get; set; } = true;
    }
}
