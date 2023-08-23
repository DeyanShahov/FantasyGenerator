using FantasyGenerator.Core.Models.Npc;

namespace FantasyGenerator.Core.Contracts
{
    public interface INpcCategoryNameService
    {
        Task<string> GetAllNpcCategoryNames();

        Task<bool> CheckForUniqueCategory(string name);

        Task<string> AddNpcNameCategory(NpcNameCategoryCreateViewModel model);

        //Task<string> NpcCategoryNameDynamically(string categoryName);
    }
}
