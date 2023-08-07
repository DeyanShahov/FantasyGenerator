using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FantasyGenerator.Infrastructure.Data.Models
{
    public class Race
    {
        [Key]
        [MaxLength(DataConstants.GuidMaxLength)]
        public Guid Id { get; init; }

        [Required]
        [MaxLength(DataConstants.Race.NameMaxLength)]
        public string Name { get; init; }

        [Required]
        [MaxLength(DataConstants.Race.DescriptionMaxLength)]
        public string Description { get; init; }

        [Required]
        [MaxLength(450)]
        public string AuthorId { get; init; }

        [ForeignKey(nameof(AuthorId))]
        public IdentityUser Author { get; init; }

        [MaxLength(DataConstants.Description)]
        public string Feats { get; init; }

        [MaxLength(DataConstants.Description)]
        public string Skills { get; init; }

        public IEnumerable<Npc> Npcs { get; set; } = new List<Npc>();

        public bool IsPublic { get; set; } = true;

    }
}
