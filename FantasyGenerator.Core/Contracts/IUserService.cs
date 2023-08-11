using Microsoft.AspNetCore.Identity;
using FantasyGenerator.Core.Models;

namespace FantasyGenerator.Core.Contracts
{
    public interface IUserService
    {
        Task<IEnumerable<UserListViewModel>> GetUsers();

        Task<UserEditViewModel> GetUsersForEdit(string id);

        Task<bool> UpdateUser(UserEditViewModel model);

        Task<IdentityUser> GetUserById(string id);
    }
}
