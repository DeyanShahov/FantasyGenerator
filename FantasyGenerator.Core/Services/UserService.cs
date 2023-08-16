
using FantasyGenerator.Core.Contracts;
using FantasyGenerator.Core.Models;
using FantasyGenerator.Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FantasyGenerator.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IApplicationDbRepository repo;
        private readonly UserManager<IdentityUser> userManager;
        private readonly IValidationService validationService;

        public UserService(IApplicationDbRepository repo, UserManager<IdentityUser> userManager, IValidationService validationService)
        {
            this.repo = repo;
            this.userManager = userManager;
            this.validationService = validationService;
        }

        public async Task<IdentityUser> GetUserById(string id)
        {
            return await repo.GetByIdAsync<IdentityUser>(id);
        }

        public async Task<IEnumerable<UserListViewModel>> GetUsers()
        {
            var users = await repo.All<IdentityUser>().ToListAsync();

            var result = users.Select(u => new UserListViewModel()
            {
                UserName = u.UserName,
                Email = u.Email,
                Id = u.Id,
                Role = string.Join(", ",  userManager.GetRolesAsync(u).Result)
            });

            return result;
        }

        public async Task<UserEditViewModel> GetUsersForEdit(string id)
        {
            var user = await repo.GetByIdAsync<IdentityUser>(id);

            return new UserEditViewModel() { Id = user.Id, Email = user.Email, PhoneNumber = user.PhoneNumber };
        }

        public async Task<bool> UpdateUser(UserEditViewModel model)
        {
            bool result = false;

            var (isValid, validationError) = validationService.ValidateModel(model);

            if (!isValid) return result;

            var user = await repo.GetByIdAsync<IdentityUser>(model.Id);

            if (user != null)
            {
                user.Email = model.Email;
                user.PhoneNumber = model.PhoneNumber;

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
