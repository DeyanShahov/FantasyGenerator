using FantasyGenerator.Core.Models.Race;

namespace FantasyGenerator.Core.Contracts
{
    public interface IRaceService
    {
         Task<string> CreateNewRace(RaceCreateViewModel model, string userId);

        Task<IEnumerable<RaceListViewModel>> GetAllRaces();

        Task<IEnumerable<RaceListViewModel>> GetMyRaces(string authorId);

        Task<RaceFullViewModel> RaceDetails(string raceId);

        Task<RaceEditViewModel> GetRaceForEdit(string raceId);

        Task<bool> UpdateRace (RaceEditViewModel model);

    }
}
