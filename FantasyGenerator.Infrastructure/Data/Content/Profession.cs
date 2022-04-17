using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FantasyGenerator.Infrastructure.Data.Content
{
    public class Profession
    {
        [Key]
        public int Id { get; init; }

        [Required]
        [MaxLength(DataConstants.Profession.NameMaxLength)]
        public string Name { get; init; }

        [Required]
        public int CategoryId { get; init; }

        [ForeignKey(nameof(CategoryId))]
        public ProfessionCategory Category { get; init; }

        [Required]
        public string Description { get; init; }

        [Required]
        public string AuthorId { get; init; }

        [ForeignKey(nameof(AuthorId))]
        public User Author { get; init; }

        public bool IsPublic { get; set; }
    }
}
