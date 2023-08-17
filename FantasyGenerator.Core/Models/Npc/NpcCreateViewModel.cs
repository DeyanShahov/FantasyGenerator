using FantasyGenerator.Core.Constants;
using FantasyGenerator.Infrastructure.Data;
using System.ComponentModel.DataAnnotations;

namespace FantasyGenerator.Core.Models.Npc
{
    public class NpcCreateViewModel
    {
        [Required]
        [StringLength(DataConstants.NpcName.NameMaxLength
          , MinimumLength = DataConstants.NpcName.NameMinLength
          , ErrorMessage = ErrorMessages.STRING_LENGTH)]
        public string FirstName { get; set; }

        [StringLength(DataConstants.NpcName.NameMaxLength
          , MinimumLength = DataConstants.NpcName.NameMinLength
          , ErrorMessage = ErrorMessages.STRING_LENGTH)]
        public string? LastName { get; set; }

        [StringLength(DataConstants.NpcName.NickNamePrefixMaxLength
          , MinimumLength = DataConstants.NpcName.NickNamePrefixMinLength
          , ErrorMessage = ErrorMessages.STRING_LENGTH)]
        public string? NickNamePrefix { get; set; }

        [StringLength(DataConstants.NpcName.NickNameSuffixMaxLength
          , MinimumLength = DataConstants.NpcName.NickNameSuffixMinLength
          , ErrorMessage = ErrorMessages.STRING_LENGTH)]
        public string? NickNameSuffix { get; set; }

        public bool IsMale { get; set; } = true;

        [Required]
        [MaxLength(DataConstants.GuidMaxLength)]
        public string RaceId { get; set; }


        [MaxLength(DataConstants.GuidMaxLength)]
        public string ProfessionId { get; set; }

        [Required]
        [StringLength(DataConstants.DescriptionMaxLength
             , MinimumLength = DataConstants.Profession.DescriptionMinLength
             , ErrorMessage = ErrorMessages.STRING_LENGTH)]
        public string Description { get; set; }
    }
}
