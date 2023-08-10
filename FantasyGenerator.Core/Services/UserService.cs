using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.Mvc;
using FantasyGenerator.Core.Contracts;
using FantasyGenerator.Core.Models;
using FantasyGenerator.Infrastructure.Data.Repositories;

namespace FantasyGenerator.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IApplicationDbRepository repo;

        public UserService(IApplicationDbRepository repo)
        {
            this.repo = repo;
        }

        public async Task<IdentityUser> GetUserById(string id)
        {
            return await repo.GetByIdAsync<IdentityUser>(id);
        }

        public async Task<IEnumerable<UserListViewModel>> GetUsers()
        {
            return await repo.All<IdentityUser>()
                .Select(u => new UserListViewModel()
                {
                    Email = u.Email,
                    Id = u.Id
                })
                .ToListAsync();
        }

        //public async Task<UserEditViewModel> GetUsersForEdit(string id)
        //{
        //    var user = await repo.GetByIdAsync<IdentityUser>(id);

        //    return new UserEditViewModel() {Id = user.Id, Email = user.Email, PhoneNumber = user.PhoneNumber };
        //}

        //public async Task<bool> UpdateUser(UserEditViewModel model)
        //{
        //    bool result = false;
        //    var user = await repo.GetByIdAsync<IdentityUser>(model.Id);

        //    if (user != null)
        //    {
        //        user.Email = model.Email;
        //        user.PhoneNumber = model.PhoneNumber;

        //        await repo.SaveChangesAsync();
        //        result = true;
        //    }
        //    return result;
        //}
    }
}
