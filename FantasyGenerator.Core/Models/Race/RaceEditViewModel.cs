using FantasyGenerator.Core.Constants;
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
        [StringLength(DataConstants.Race.NameMaxLength
          , MinimumLength = DataConstants.Race.NameMinLength
          , ErrorMessage = ErrorMessages.STRING_LENGTH)]
        public string Name { get; set; }

        [Required]
        [StringLength(DataConstants.DescriptionMaxLength
            , MinimumLength = DataConstants.Profession.DescriptionMinLength
            , ErrorMessage = ErrorMessages.STRING_LENGTH)]
        public string Description { get; set; }

        [Required]
        [StringLength(DataConstants.Feat.NameMaxLength
            , MinimumLength = DataConstants.Feat.NameMinLength
            , ErrorMessage = ErrorMessages.STRING_LENGTH)]
        public string Feats { get; set; }

        [Required]
        [StringLength(DataConstants.Skill.NameMaxLength
            , MinimumLength = DataConstants.Skill.NameMinLength
            , ErrorMessage = ErrorMessages.STRING_LENGTH)]
        public string Skills { get; set; }

        [Required]
        [MaxLength(450)]
        public string AuthorId { get; set; }

    }
}
