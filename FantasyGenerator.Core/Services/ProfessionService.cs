using FantasyGenerator.Core.Constants;
using FantasyGenerator.Core.Contracts;
using FantasyGenerator.Core.Models.Profession;
using FantasyGenerator.Core.Models.Race;
using FantasyGenerator.Infrastructure.Data.Content;
using FantasyGenerator.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FantasyGenerator.Core.Services
{
    public class ProfessionService : IProfessionService
    {
        private readonly IApplicationDbRepository repo;
        private readonly IValidationService validationService;
        private readonly IUserService userService;

        public ProfessionService(IApplicationDbRepository repo, IValidationService validationService, IUserService userService)
        {
            this.repo = repo;
            this.validationService = validationService;
            this.userService = userService;
        }
        public async Task<string> CreateNewProfession(ProfessionCreateViewModel model, string userId)
        {
            string error = null;

            var (isValid, validationError) = validationService.ValidateModel(model);

            if (!isValid) return validationError;

            Profession profession = new Profession()
            {
                Name = model.Name.Trim(),
                Description = model.Description.Trim(),
                Category = model.Category.Trim(),
                AuthorId = userId
            };


            try
            {
                var isContains = await repo.All<Profession>()
                .Where(p => p.Name == profession.Name)
                .FirstOrDefaultAsync();

                if (isContains != null) return $"{ErrorMessages.ELEMENT_EXIST.Replace("{0}", "Profession")}";

                await repo.AddAsync(profession);
                await repo.SaveChangesAsync();
            }
            catch (Exception e)
            {
                error = $"{ErrorMessages.DB_ERROR}: {e}";
            }

            return error;
        }

        public async Task<IEnumerable<ProfessionListViewModel>> GetAllProfession()
        {
            var allProf = await repo.All<Profession>()
               .Select(r => new ProfessionListViewModel()
               {
                   Name = r.Name,
                   Description = r.Description,
                   Category = r.Category,
                   AuthorName = r.Author.UserName,
                   Id = r.Id.ToString()
               })
               .ToListAsync();

            return allProf;
        }
    }
}
