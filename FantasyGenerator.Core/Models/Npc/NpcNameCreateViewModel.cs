using FantasyGenerator.Core.Constants;
using FantasyGenerator.Infrastructure.Data;
using System.ComponentModel.DataAnnotations;

namespace FantasyGenerator.Core.Models.Npc
{
    public class NpcNameCreateViewModel
    {
        [Required]
        [StringLength(DataConstants.NpcName.NameMaxLength
         , MinimumLength = DataConstants.NpcName.NameMinLength
         , ErrorMessage = ErrorMessages.STRING_LENGTH)]
        public string Name { get; set; }

        public bool IsMale { get; set; } = true;

        public bool IsFirstName { get; set; } = true;

        [StringLength(DataConstants.NpcCategoryName.NameMaxLength
            , MinimumLength = DataConstants.NpcCategoryName.NameMinLength
            , ErrorMessage = ErrorMessages.STRING_LENGTH)]
        public string? CategoryName { get; set; }

        [StringLength(DataConstants.Race.NameMaxLength
            , MinimumLength = DataConstants.Race.NameMinLength
            , ErrorMessage = ErrorMessages.STRING_LENGTH)]
        public string? SuitableRace { get; set; }
    }
}
