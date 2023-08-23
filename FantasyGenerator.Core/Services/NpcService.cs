using FantasyGenerator.Core.Constants;
using FantasyGenerator.Core.Contracts;
using FantasyGenerator.Core.Models.Npc;
using FantasyGenerator.Infrastructure.Data;
using FantasyGenerator.Infrastructure.Data.Modles;
using FantasyGenerator.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace FantasyGenerator.Core.Services
{
    public class NpcService : INpcService
    {
        private readonly IApplicationDbRepository repo;
        private readonly IValidationService validationService;
        private readonly IUserService userService;

        public NpcService(IApplicationDbRepository repo, IValidationService validationService, IUserService userService)
        {
            this.repo = repo;
            this.validationService = validationService;
            this.userService = userService;
        }

        public async Task<string> CreateNewNpc(NpcCreateViewModel model, string userId)
        {
            string error = null;

            var (isValid, validationError) = validationService.ValidateModel(model);

            if (!isValid) return validationError;


            Npc npc = new Npc()
            {
                FirstName = model.FirstName.Trim(),
                LastName = model.LastName?.Trim(),
                NickNamePrefix = model.NickNamePrefix?.Trim(),
                NickNameSuffix = model.NickNameSuffix?.Trim(),
                IsMale = model.IsMale,
                Description = model.Description.Trim(),
                AuthorId = userId
            };

            Guid guidParse;

            if (Guid.TryParse(model.RaceId, out guidParse)) npc.RaceId = guidParse;
            else error = "Invalid Race";

            if (Guid.TryParse(model.ProfessionId, out guidParse)) npc.ProfessionId = guidParse;
            else error = "Invalid Profession";



            try
            {
                await repo.AddAsync(npc);
                await repo.SaveChangesAsync();
            }
            catch (Exception e)
            {
                error = $"{ErrorMessages.DB_ERROR}: {e}";
            }

            return error;
        }

        public async Task<string> AddNewNpcName(NpcNameCreateViewModel model)
        {
            string error = null;

            var (isValid, validationError) = validationService.ValidateModel(model);

            if (!isValid) return validationError;

            var namesList = model.Name.Split(',');

            var npcNamesList = new List<NpcName>();

            foreach (var npcName in namesList)
            {
                npcNamesList.Add(
                    new NpcName()
                    {
                        Name = npcName.Trim(),
                        IsMale = model.IsMale,
                        IsFirstName = model.IsFirstName,
                        CategoryName = model.CategoryName,
                        SuitableRace = model.SuitableRace
                    });
            }

            try
            {
                await repo.AddRangeAsync(npcNamesList);
                await repo.SaveChangesAsync();
            }
            catch (Exception e)
            {
                error = $"{ErrorMessages.DB_ERROR}: {e}";
            }

            return error;
        }

        public async Task<bool> DeleteNpc(string npcId)
        {
            try
            {
                var npc = await repo.All<Npc>().FirstOrDefaultAsync(p => p.Id.ToString() == npcId);
                await repo.DeleteAsync<Npc>(npc.Id);
                await repo.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<NpcListViewModel>> GetAllNpc()
        {
            var allNpc = await repo.All<Npc>()
              .Select(n => new NpcListViewModel()
              {
                  Name = $"{n.FirstName} {n.LastName}",
                  Gender = n.IsMale ? "Male" : "Female",
                  Race = n.Race.Name,
                  AuthorName = n.Author.UserName,
                  Id = n.Id.ToString()
              })
              .ToListAsync();

            return allNpc;
        }

        public async Task<IEnumerable<NpcListViewModel>> GetMyNpc(string authorId)
        {
            return await repo.All<Npc>()
                .Where(n => n.AuthorId == authorId)
                .Select(n => new NpcListViewModel()
                {
                    Name = $"{n.FirstName} {n.LastName}",
                    Gender = n.IsMale ? "Male" : "Female",
                    Race = n.Race.Name,
                    AuthorName = n.Author.UserName,
                    Id = n.Id.ToString()
                })
               .ToListAsync();
        }

        public async Task<NpcEditViewModel> GetNpcForEdit(string npcId)
        {
            var npc = await repo.All<Npc>()
                .Include(r => r.Race)
                .Include(p => p.Profession)
                .FirstOrDefaultAsync(p => p.Id.ToString() == npcId);

            if (npc == null) return null;

            var model = new NpcEditViewModel()
            {
                Id = npc.Id.ToString(),
                FirstName = npc.FirstName,
                LastName = npc.LastName,
                NickNamePrefix = npc.NickNamePrefix,
                NickNameSuffix = npc.NickNameSuffix,
                IsMale = npc.IsMale,
                RaceId = npc.Race.Name,
                ProfessionId = npc.Profession.Name,
                Description = npc.Description,
                AuthorId = npc.AuthorId
            };

            return model;
        }

        public async Task<NpcFullViewModel> NpcDetails(string npcId)
        {
            var npc = await repo.All<Npc>()
                .Include(a => a.Author)
                .Include(r => r.Race)
                .Include(p => p.Profession)
                .FirstOrDefaultAsync(n => n.Id.ToString() == npcId);

            if (npc == null) return null;

            //var author = await userService.GetUserById(npc.AuthorId);

            var viewModel = new NpcFullViewModel
            {
                FirstName = npc.FirstName,
                LastName = npc.LastName,
                NickNamePrefix = npc.NickNamePrefix,
                NickNameSuffix = npc.NickNameSuffix,
                IsMale = npc.IsMale ? "Male" : "Female",
                Race = npc.Race.Name,
                Profession = npc.Profession.Name,
                Description = npc.Description,
                Author = npc.Author.UserName
            };

            return viewModel;
        }

        public async Task<bool> UpdateNpc(NpcEditViewModel model)
        {
            bool result = false;

            var (isValid, validationError) = validationService.ValidateModel(model);

            if (!isValid) return result;

            var npc = await repo.All<Npc>().FirstOrDefaultAsync(n => n.Id.ToString() == model.Id);

            if (npc != null && npc.Id.ToString() == model.Id && npc.AuthorId == model.AuthorId)
            {
                npc.FirstName = model.FirstName;
                npc.LastName = model.LastName;
                npc.NickNamePrefix = model.NickNamePrefix;
                npc.NickNameSuffix = model.NickNameSuffix;
                npc.IsMale = model.IsMale;
                npc.Description = model.Description;

                try
                {
                    Guid guidParse;

                    if (Guid.TryParse(model.RaceId, out guidParse)) npc.RaceId = guidParse;

                    if (Guid.TryParse(model.ProfessionId, out guidParse)) npc.ProfessionId = guidParse;

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

        public async Task<string> GetAllNpcNames()
        {
            var nameList = await repo.All<NpcName>()
                 .Select(n => n.Name)
                 .ToListAsync();

            return String.Join(", ", nameList);
        }

        public async Task<string> GetAllNpcCategoryNames()
        {
            var categoriesList = await repo.All<NpcCategoryName>()
                .Select(n => n.Name)
                .ToListAsync();

            return String.Join(", ", categoriesList);
        }

        public async Task<string> AddNpcNameCategory(NpcNameCategoryCreateViewModel model)
        {
            string error = null;

            var (isValid, validationError) = validationService.ValidateModel(model);

            if (!isValid) return validationError;

            var newCategory = new NpcCategoryName()
            {
                Name = model.Name.Trim(),
                Description = String.IsNullOrWhiteSpace(model.Description) ? "Default empty description" : model.Description.Trim()
            };


            try
            {
                await repo.AddAsync(newCategory);
                await repo.SaveChangesAsync();
            }
            catch (Exception e)
            {
                error = $"{ErrorMessages.DB_ERROR}: {e}";
            }

            return error;
        }

        public async Task<(string, string)> FilterNpcName(string npcName)
        {
            var namesFromModel = npcName.Split(',');

            string allNpcNames = await GetAllNpcNames();

            var duplicateNames = new StringBuilder();
            var uniqueNames = new StringBuilder();

            foreach (var name in namesFromModel)
            {
                if (allNpcNames.Contains(name)) duplicateNames.Append(name).Append(',');
                else uniqueNames.Append(name).Append(',');
            }

            string duplicate = duplicateNames.ToString().Trim(',');
            string unique = uniqueNames.ToString().Trim(',');

            return (duplicate, unique);
        }

        public async Task<bool> CheckForUniqueCategory(string name)
        {
            var categoryList = await repo.All<NpcCategoryName>().ToListAsync();

            var result = categoryList.Any(cn => cn.Name.ToLower() == name.Trim().ToLower());

            return result;
        }

        //public async Task<string> NpcCategoryNameDynamically(string categoryName)
        //{
        //    var categoryList = await GetAllNpcCategoryNames();

        //    var category = categoryName.Split("//")[0];
        //    string description = null;

        //    if (categoryName.Contains("//"))
        //    {
        //        description = categoryName.Split("//")?[1];
        //    }
            

        //    if (!categoryList.Contains(categoryName))
        //    {
        //        var result = await AddNpcNameCategory(new NpcNameCategoryCreateViewModel { Name = category, Description = description ?? null });
        //        return result;
        //    }

        //    return null;
        //}
    }
}
