using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FantasyGenerator.Infrastructure.Data.Content
{
    public class NpcName
    {
        [Key]
        public int Id { get; init; }

        [Required]
        [MaxLength(DataConstants.NpcName.NameMaxLength)]
        public string Name { get; init; }

        public bool IsMale { get; init; }

        public bool IsFirstName { get; init; }

        [Required]
        public int CategoryId { get; init; }

        [ForeignKey(nameof(CategoryId))]
        public NpcCategoryName Category { get; init; }

        [Required]
        public int RaceId { get; init; }

        [ForeignKey(nameof(RaceId))]
        public Race Race { get; init; }

        [Required]
        public string AuthorId { get; init; }

        [ForeignKey(nameof(AuthorId))]
        public User Author { get; init; }

        public bool IsPublic { get; set; }
    }
}
