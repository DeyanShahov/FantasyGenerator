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

        public RaceService(IApplicationDbRepository repo, IValidationService validationService)
        {
            this.repo = repo;
            this.validationService = validationService;
        }

        public async Task<string> CreateNewRace(RaceCreateViewModel model, string userId)
        {
            string error = null;

            //proverka za validnost na modela
            var (isValid, validationError) = validationService.ValidateModel(model);

            if (!isValid) return validationError;

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
    }
}
