using FantasyGenerator.Core.Models.Profession;

namespace FantasyGenerator.Core.Contracts
{
    public interface IProfessionService
    {
        Task<string> CreateNewProfession(ProfessionCreateViewModel model, string userId);

        Task<IEnumerable<ProfessionListViewModel>> GetAllProfession();

        Task<IEnumerable<ProfessionListViewModel>> GetMyProfessions(string authorId);

        Task<ProfessionFullViewModel> ProfessionDetails(string professionId);

        Task<ProfessionEditViewModel> GetProfessionForEdit(string professionId);

        Task<bool> UpdateProfession(ProfessionEditViewModel model);

        Task<bool> DeleteProfession(string professionId);
    }
}
