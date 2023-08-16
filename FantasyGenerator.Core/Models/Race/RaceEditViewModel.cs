using FantasyGenerator.Infrastructure.Data;
using System.ComponentModel.DataAnnotations;

namespace FantasyGenerator.Core.Models.Race
{
    public class RaceEditViewModel
    {
        [Required]
        [MaxLength(450)]
        public string Id { get; set; }

        [Required]
        [MaxLength(DataConstants.Race.NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(DataConstants.Race.DescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        [MaxLength(DataConstants.DescriptionMaxLength)]
        public string Feats { get; set; }

        [Required]
        [MaxLength(DataConstants.DescriptionMaxLength)]
        public string Skills { get; set; }

        [Required]
        [MaxLength(450)]
        public string AuthorId { get; set; }

    }
}
