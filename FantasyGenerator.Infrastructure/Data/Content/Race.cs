using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FantasyGenerator.Infrastructure.Data.Content
{
    public class Race
    {
        [Key]
        public int Id { get; init; }

        [Required]
        [MaxLength(DataConstants.Race.NameMaxLength)]
        public string Name { get; init; }

        [Required]
        public string Description { get; init; }

        [Required]
        public string AuthorId { get; init; }

        [ForeignKey(nameof(AuthorId))]
        public User Author { get; init; }

        public bool IsPublic { get; set; }

        public IEnumerable<Feat> Feats { get; set; } = new List<Feat>();

        public IEnumerable<Skill> Skills { get; set; } = new List<Skill>();
    }
}
