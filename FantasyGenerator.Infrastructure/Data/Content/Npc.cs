using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FantasyGenerator.Infrastructure.Data.Content
{
    public class Npc
    {
        [Key]
        public int Id { get; init; }

        [Required]
        [MaxLength(DataConstants.Npc.FirstNameMaxLength)]
        public string FirstName { get; init; }

        [MaxLength(DataConstants.Npc.LastNameMaxLength)]
        public string? LastName { get; init; }

        [MaxLength(DataConstants.NpcName.NickNamePrefixMaxLength)]
        public string?  NickNamePrefix { get; init; }

        [MaxLength(DataConstants.NpcName.NickNameSuffixMaxLength)]
        public string? NickNameSuffix { get; init; }

        public bool IsMale { get; init; }

        [Required]
        public int RaceId { get; init; }

        [ForeignKey(nameof(RaceId))]
        public Race Race { get; init; }

        [Required]
        public int ProfessionId { get; init; }

        [ForeignKey(nameof(ProfessionId))]
        public Profession Profession { get; init; }


        [Required]
        public string Description { get; init; }

        [Required]
        public string AuthorId { get; init; }

        [ForeignKey(nameof(AuthorId))]
        public User Author { get; init; }

        public bool IsPublic { get; set; }
    }
}
