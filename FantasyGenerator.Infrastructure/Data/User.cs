using FantasyGenerator.Infrastructure.Data.Content;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FantasyGenerator.Infrastructure.Data
{
    public class User : IdentityUser
    {
        [Required]
        [MaxLength(DataConstants.User.NameMaxLength)]
        public string Name { get; set; }

        public IEnumerable<Race> Races { get; set; } = new List<Race>();
        public IEnumerable<Feat> Feats { get; set; } = new List<Feat>();
        public IEnumerable<Skill> Skills { get; set; } = new List<Skill>();

        public IEnumerable<NpcCategoryName> npcCategoryNames { get; set; } = new List<NpcCategoryName>();

        public IEnumerable<NpcName> npcNames { get; set; } = new List<NpcName>();

    }
}
