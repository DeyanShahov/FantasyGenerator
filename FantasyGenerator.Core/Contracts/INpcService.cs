using FantasyGenerator.Core.Models.Npc;

namespace FantasyGenerator.Core.Contracts
{
    public interface INpcService
    {
        Task<string> CreateNewNpc(NpcCreateViewModel model, string userId);

        Task<IEnumerable<NpcListViewModel>> GetAllNpc();

        Task<IEnumerable<NpcListViewModel>> GetMyNpc(string authorId);

        //Task<ProfessionFullViewModel> ProfessionDetails(string professionId);

        //Task<ProfessionEditViewModel> GetProfessionForEdit(string professionId);

        //Task<bool> UpdateProfession(ProfessionEditViewModel model);

        //Task<bool> DeleteProfession(string professionId);
    }
}
