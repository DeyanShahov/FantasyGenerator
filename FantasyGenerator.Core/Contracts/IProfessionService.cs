using FantasyGenerator.Core.Models.Profession;

namespace FantasyGenerator.Core.Contracts
{
    public interface IProfessionService
    {
        Task<string> CreateNewProfession(ProfessionCreateViewModel model, string userId);

        Task<IEnumerable<ProfessionListViewModel>> GetAllProfession();

        //Task<IEnumerable<RaceListViewModel>> GetMyRaces(string authorId);

        //Task<RaceFullViewModel> RaceDetails(string raceId);

        //Task<RaceEditViewModel> GetRaceForEdit(string raceId);

        //Task<bool> UpdateRace(RaceEditViewModel model);
    }
}
