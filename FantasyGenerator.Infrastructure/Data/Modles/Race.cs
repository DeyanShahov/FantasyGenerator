using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FantasyGenerator.Infrastructure.Data.Models
{
    public class Race
    {
        [Key]
        [MaxLength(DataConstants.GuidMaxLength)]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(DataConstants.Race.NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(DataConstants.Race.DescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        [MaxLength(450)]
        public string AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public IdentityUser Author { get; set; }

        [MaxLength(DataConstants.DescriptionMaxLength)]
        public string Feats { get; set; }

        [MaxLength(DataConstants.DescriptionMaxLength)]
        public string Skills { get; set; }

        public IEnumerable<Npc> Npcs { get; set; } = new List<Npc>();

        public bool IsPublic { get; set; } = true;

    }
}
