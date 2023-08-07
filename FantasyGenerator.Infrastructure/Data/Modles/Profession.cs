using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FantasyGenerator.Infrastructure.Data.Content
{
    public class Profession
    {
        [Key]
        [MaxLength(DataConstants.GuidMaxLength)]
        public Guid Id { get; init; } = Guid.NewGuid();

        [Required]
        [MaxLength(DataConstants.Profession.NameMaxLength)]
        public string Name { get; init; }

        [Required]
        [MaxLength(DataConstants.Profession.NameMaxLength)]
        public string Category { get; init; }

        [Required]
        [MaxLength(DataConstants.DescriptionMaxLength)]
        public string Description { get; init; }

        [Required]
        public string AuthorId { get; init; }

        [ForeignKey(nameof(AuthorId))]
        public IdentityUser Author { get; init; }

        public bool IsPublic { get; set; }

        public IEnumerable<Npc> Npcs { get; set; } = new List<Npc>();
    }
}
