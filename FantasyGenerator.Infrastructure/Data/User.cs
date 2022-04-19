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

        public IEnumerable<NpcCategoryName> NpcCategoryNames { get; set; } = new List<NpcCategoryName>();

        public IEnumerable<NpcName> NpcNames { get; set; } = new List<NpcName>();

        public IEnumerable<ProfessionCategory> ProfessionCategories { get; set; } = new List<ProfessionCategory>();

        public IEnumerable<Profession> Professions { get; set; } = new List<Profession>();

        public IEnumerable<Npc> Npcs { get; set; } = new List<Npc>();
    }
}
