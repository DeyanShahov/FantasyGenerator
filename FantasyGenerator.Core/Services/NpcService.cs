using FantasyGenerator.Core.Constants;
using FantasyGenerator.Core.Contracts;
using FantasyGenerator.Core.Models.Npc;
using FantasyGenerator.Core.Models.Profession;
using FantasyGenerator.Infrastructure.Data;
using FantasyGenerator.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;

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
    }
}
