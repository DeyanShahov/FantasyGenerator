using FantasyGenerator.Core.Contracts;
using FantasyGenerator.Core.Models.Race;
using FantasyGenerator.Infrastructure.Data.Models;
using FantasyGenerator.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FantasyGenerator.Core.Services
{
    public class RaceService : IRaceService
    {
        private readonly IApplicationDbRepository repo;
        private readonly IValidationService validationService;
        private readonly IUserService userService;

        public RaceService(IApplicationDbRepository repo, IValidationService validationService, IUserService userService)
        {
            this.repo = repo;
            this.validationService = validationService;
            this.userService = userService;
        }

        public async Task<string> CreateNewRace(RaceCreateViewModel model, string userId)
        {
            string error = null;

            //proverka za validnost na modela
            //var (isValid, validationError) = validationService.ValidateModel(model);

            //if (!isValid) return validationError;

            Race race = new Race()
            {
                Name = model.Name.Trim(),
                Description = model.Description.Trim(),
                Feats = model.Feats.Trim(),
                Skills = model.Skills.Trim(),
                //AuthorId = model.AuthorId,
                AuthorId = userId
            };

            var isContains = await repo.All<Race>()
                .Where(r => r.Name == race.Name)
                .FirstOrDefaultAsync();

            if (isContains != null) return "Race already exist.";

            try
            {
                await repo.AddAsync(race);
                await repo.SaveChangesAsync();
            }
            catch (Exception e)
            {
                error = $"DB error: {e}";
            }

            return error;
        }

        public async Task<IEnumerable<RaceListViewModel>> GetAllRaces()
        {
            var allRaces = await repo.All<Race>()
                .Select(r => new RaceListViewModel()
                {
                    Name = r.Name,
                    Description = r.Description,
                    //AuthorId = r.AuthorId,
                    AuthorName = r.Author.UserName,
                    Id = r.Id.ToString()
                })
                .ToListAsync();

            //var author = await userService.GetUserById(race.AuthorId);

            return allRaces;
        }

        public async Task<IEnumerable<RaceListViewModel>> GetMyRaces(string authorId)
        {
            return await repo.All<Race>()
                 .Where(r => r.AuthorId == authorId)
                 .Select(r => new RaceListViewModel()
                 {
                     Name = r.Name,
                     Description = r.Description,
                     //AuthorId = r.AuthorId,
                     Id = r.Id.ToString()
                 })
                .ToListAsync();
        }

        public async Task<RaceEditViewModel> GetRaceForEdit(string raceId)
        {
            var race = await repo.All<Race>().FirstOrDefaultAsync(r => r.Id.ToString() == raceId);

            if (race == null) return null;

            var model = new RaceEditViewModel()
            {
                Id = race.Id.ToString(),
                Name = race.Name,
                Description = race.Description,
                Feats = race.Feats,
                Skills = race.Skills,
                AuthorId = race.AuthorId

            };

            return model;
        }

        public async Task<RaceFullViewModel> RaceDetails(string raceId)
        {
            int inter = 1;

            var race = await repo.All<Race>().FirstOrDefaultAsync(r => r.Id.ToString() == raceId);

            if (race == null) return null;

            var author = await userService.GetUserById(race.AuthorId);

            var viewModel = new RaceFullViewModel
            {
                Name = race.Name,
                Description = race.Description,
                Author = author.UserName,
                Skills = race.Skills,
                Feats = race.Feats
            };

            return viewModel;
        }

        public async Task<bool> UpdateRace(RaceEditViewModel model)
        {
            bool result = false;

            //var race = await repo.GetByIdAsync<Race>(model.Id);
            var race = await  repo.All<Race>().FirstOrDefaultAsync(r => r.Id.ToString() == model.Id);



            if (race != null && race.Id.ToString() == model.Id && race.AuthorId == model.AuthorId)
            {
                race.Name = model.Name;
                race.Description = model.Description;
                race.Feats = model.Feats;
                race.Skills = model.Skills;

                await repo.SaveChangesAsync();
                result = true;
            }

            return result;
        }
    }
}
