using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FantasyGenerator.Infrastructure.Data.Content
{
    public class Profession
    {
        [Key]
        [MaxLength(DataConstants.GuidMaxLength)]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(DataConstants.Profession.NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(DataConstants.Profession.NameMaxLength)]
        public string Category { get; set; }

        [Required]
        [MaxLength(DataConstants.DescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        public string AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public IdentityUser Author { get; set; }

        public bool IsPublic { get; set; } = true;

        public IEnumerable<Npc> Npcs { get; set; } = new List<Npc>();
    }
}
