using FantasyGenerator.Core.Constants;
using FantasyGenerator.Infrastructure.Data;
using System.ComponentModel.DataAnnotations;

namespace FantasyGenerator.Core.Models.Profession
{
    public class ProfessionCreateViewModel
    {
        [Required]
        [StringLength(DataConstants.Profession.NameMaxLength
          , MinimumLength = DataConstants.Profession.NameMinLength
          , ErrorMessage = ErrorMessages.STRING_LENGTH)]
        public string Name { get; set; }

        [Required]
        [StringLength(DataConstants.DescriptionMaxLength
            , MinimumLength = DataConstants.Profession.DescriptionMinLength
            , ErrorMessage = ErrorMessages.STRING_LENGTH)]
        public string Description { get; set; }

        [Required]
        [StringLength(DataConstants.Profession.CategoryMaxLength
            , MinimumLength = DataConstants.Profession.CategoryMinLength
            , ErrorMessage = ErrorMessages.STRING_LENGTH)]
        public string Category { get; set; }
    }
}
