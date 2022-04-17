using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FantasyGenerator.Infrastructure.Data.Content
{
    public class Feat
    {
        [Key]
        public int Id { get; init; }

        [Required]
        [MaxLength(DataConstants.Feat.NameMaxLength)]
        public string Name { get; init; }

        [Required]
        public string Description { get; init; }

        [MaxLength(DataConstants.Feat.PrerequisiteMaxLength)]
        public string? Prerequisite { get; init; }

        [Required]
        public string AuthorId { get; init; }

        [ForeignKey(nameof(AuthorId))]
        public User Author { get; init; }

        public bool IsPublic { get; set; }

    }
}