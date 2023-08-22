using FantasyGenerator.Core.Constants;
using FantasyGenerator.Infrastructure.Data;
using System.ComponentModel.DataAnnotations;

namespace FantasyGenerator.Core.Models.Npc
{
    public class NpcNameCategoryCreateViewModel
    {
        [Required]
        [StringLength(DataConstants.NpcCategoryName.NameMaxLength
         , MinimumLength = DataConstants.NpcCategoryName.NameMinLength
         , ErrorMessage = ErrorMessages.STRING_LENGTH)]
        public string Name { get; set; }


        [Required]
        [StringLength(DataConstants.DescriptionMaxLength
           , MinimumLength = DataConstants.Profession.DescriptionMinLength
           , ErrorMessage = ErrorMessages.STRING_LENGTH)]
        public string Description { get; set; }
    }
}
