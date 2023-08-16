using FantasyGenerator.Core.Constants;
using FantasyGenerator.Core.Contracts;
using FantasyGenerator.Core.Models.Profession;
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

        public async Task<bool> DeleteProfession(string professionId)
        {
            try
            {
                var prof = await repo.All<Profession>().FirstOrDefaultAsync(p => p.Id.ToString() == professionId);
                await repo.DeleteAsync<Profession>(prof.Id);
                await repo.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
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

        public async Task<IEnumerable<ProfessionListViewModel>> GetMyProfessions(string authorId)
        {
            return await repo.All<Profession>()
                .Where(p => p.AuthorId == authorId)
                .Select(p => new ProfessionListViewModel()
                {
                    Name = p.Name,
                    Description = p.Description,
                    Category = p.Category,
                    Id = p.Id.ToString()
                })
               .ToListAsync();
        }

        public async Task<ProfessionEditViewModel> GetProfessionForEdit(string professionId)
        {
            var prof = await repo.All<Profession>().FirstOrDefaultAsync(p => p.Id.ToString() == professionId);

            if (prof == null) return null;

            var model = new ProfessionEditViewModel()
            {
                Id = prof.Id.ToString(),
                Name = prof.Name,
                Description = prof.Description,
                Category = prof.Category,
                AuthorId = prof.AuthorId

            };

            return model;
        }

        public async Task<ProfessionFullViewModel> ProfessionDetails(string professionId)
        {
            var prof = await repo.All<Profession>().FirstOrDefaultAsync(p => p.Id.ToString() == professionId);

            if (prof == null) return null;

            var author = await userService.GetUserById(prof.AuthorId);

            var viewModel = new ProfessionFullViewModel
            {
                Name = prof.Name,
                Description = prof.Description,
                Category = prof.Category,
                Author = author.UserName,
            };

            return viewModel;
        }

        public async Task<bool> UpdateProfession(ProfessionEditViewModel model)
        {
            bool result = false;

            var (isValid, validationError) = validationService.ValidateModel(model);

            if (!isValid) return result;
           
            var prof = await repo.All<Profession>().FirstOrDefaultAsync(p => p.Id.ToString() == model.Id);

            if (prof != null && prof.Id.ToString() == model.Id && prof.AuthorId == model.AuthorId)
            {
                prof.Name = model.Name;
                prof.Description = model.Description;
                prof.Category = model.Category;

                try
                {
                    await repo.SaveChangesAsync();
                    result = true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            return result;
        }
    }
}
