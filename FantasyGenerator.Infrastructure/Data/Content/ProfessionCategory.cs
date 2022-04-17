using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FantasyGenerator.Infrastructure.Data.Content
{
    public class ProfessionCategory
    {
        [Key]
        public int Id { get; init; }

        [Required]
        [MaxLength(DataConstants.ProfessionCategory.NameMaxLength)]
        public string Name { get; init; }

        [Required]
        [MaxLength(DataConstants.ProfessionCategory.DescriptionMaxLength)]
        public string Description { get; init; }

        [Required]
        public string AuthorId { get; init; }

        [ForeignKey(nameof(AuthorId))]
        public User Author { get; init; }

        public bool IsPublic { get; set; }
    }
}
