using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FantasyGenerator.Infrastructure.Data.Content
{
    public class NpcCategoryName
    {
        [Key]
        public int Id { get; init; }

        [Required]
        [MaxLength(DataConstants.NpcCategoryName.NameMaxLength)]
        public string Name { get; init; }

        [Required]
        [MaxLength(DataConstants.NpcCategoryName.DescriptionMaxLength)]
        public string Description { get; init; }

        [Required]
        public string AuthorId { get; init; }

        [ForeignKey(nameof(AuthorId))]
        public User Author { get; init; }

        public bool IsPublic { get; set; }
    }
}