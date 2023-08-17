using FantasyGenerator.Core.Constants;
using FantasyGenerator.Infrastructure.Data;
using System.ComponentModel.DataAnnotations;

namespace FantasyGenerator.Core.Models.Npc
{
    public class NpcCreateViewModel
    {
        [Required]
        [Display(Name = "Firs Name")]
        [StringLength(DataConstants.NpcName.NameMaxLength
          , MinimumLength = DataConstants.NpcName.NameMinLength
          , ErrorMessage = ErrorMessages.STRING_LENGTH)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(DataConstants.NpcName.NameMaxLength
          , MinimumLength = DataConstants.NpcName.NameMinLength
          , ErrorMessage = ErrorMessages.STRING_LENGTH)]
        public string? LastName { get; set; }

        [Display(Name = "Nickname Prefix")]
        [StringLength(DataConstants.NpcName.NickNamePrefixMaxLength
          , MinimumLength = DataConstants.NpcName.NickNamePrefixMinLength
          , ErrorMessage = ErrorMessages.STRING_LENGTH)]
        public string? NickNamePrefix { get; set; }

        [Display(Name = "Nickname Suffix")]
        [StringLength(DataConstants.NpcName.NickNameSuffixMaxLength
          , MinimumLength = DataConstants.NpcName.NickNameSuffixMinLength
          , ErrorMessage = ErrorMessages.STRING_LENGTH)]
        public string? NickNameSuffix { get; set; }

        public bool IsMale { get; set; } = true;

        [Required]
        [Display(Name = "Race")]
        [MaxLength(DataConstants.GuidMaxLength)]
        public string RaceId { get; set; }

        [Display(Name = "Profession")]
        [MaxLength(DataConstants.GuidMaxLength)]
        public string ProfessionId { get; set; }

        [Required]
        [StringLength(DataConstants.DescriptionMaxLength
             , MinimumLength = DataConstants.Profession.DescriptionMinLength
             , ErrorMessage = ErrorMessages.STRING_LENGTH)]
        public string Description { get; set; }
    }
}
