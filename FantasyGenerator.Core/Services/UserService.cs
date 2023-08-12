
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
        private readonly UserManager<IdentityUser> _userManager;

        public UserService(IApplicationDbRepository repo, UserManager<IdentityUser> userManager)
        {
            this.repo = repo;
            _userManager = userManager;
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
                Role = string.Join(", ",  _userManager.GetRolesAsync(u).Result)
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
            var user = await repo.GetByIdAsync<IdentityUser>(model.Id);

            if (user != null)
            {
                user.Email = model.Email;
                user.PhoneNumber = model.PhoneNumber;

                await repo.SaveChangesAsync();
                result = true;
            }
            return result;
        }
    }
}
