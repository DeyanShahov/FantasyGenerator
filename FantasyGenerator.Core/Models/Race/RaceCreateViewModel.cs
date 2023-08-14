using FantasyGenerator.Infrastructure.Data;
using System.ComponentModel.DataAnnotations;

namespace FantasyGenerator.Core.Models.Race
{
    public class RaceCreateViewModel
    {
        [Required]
        [MaxLength(DataConstants.Race.NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(DataConstants.Race.DescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        [MaxLength(DataConstants.DescriptionMaxLength)]
        public string Feats { get; init; }

        [Required]
        [MaxLength(DataConstants.DescriptionMaxLength)]
        public string Skills { get; init; }

        //[Required]
        //[MaxLength(450)]
        //public string AuthorId { get; init; }
    }
}
