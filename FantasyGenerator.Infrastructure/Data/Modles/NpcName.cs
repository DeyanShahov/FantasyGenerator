using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FantasyGenerator.Infrastructure.Data.Modles
{
    public class NpcName
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(DataConstants.NpcName.NameMaxLength)]
        public string Name { get; set; }

        public bool IsMale { get; set; } = true;

        public bool IsFirstName { get; set; } = true;

        [MaxLength(DataConstants.NpcCategoryName.NameMaxLength)]
        public string? CategoryName { get; set; }

        [MaxLength(DataConstants.Race.NameMaxLength)]
        public string? SuitableRace { get; set; }

        public bool IsPublic { get; set; } = true;
    }
}
