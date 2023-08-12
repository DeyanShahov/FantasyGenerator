using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using FantasyGenerator.Core.Constants;
using Microsoft.AspNetCore.Authorization;
using FantasyGenerator.Core.Contracts;
using FantasyGenerator.Core.Models;

namespace FantasyGenerator.Controllers
{
    public class UserController : BaseController
    {

        private readonly RoleManager<IdentityRole> _roleManager;

        private readonly UserManager<IdentityUser> _userManager;

        private readonly IUserService _userService;

        public UserController(RoleManager<IdentityRole> roleManager, IUserService userService, UserManager<IdentityUser> userManager)
        {
            _roleManager = roleManager;
            _userService = userService;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ChangeUsername(string id)
        {
            var user = await _userService.GetUserById(id);

            if (user == null) return View();

            return View(new ChangeUsernameModel() { Id = user.Id, UserName = user.UserName});
        }

        [HttpPost]
        public async Task<IActionResult> ChangeUsername(ChangeUsernameModel model)
        {
            var user = await _userService.GetUserById(model.Id);

            if (user != null)
            {
                user.UserName = "Petkan";
                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    // Успешно обновен Username
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    // Грешка при обновяването на Username
                    ModelState.AddModelError("", "Грешка при обновяването на потребителското име.");
                    return View();
                }
            }
            return View();
        }


        public async Task<IActionResult> ManageUsers()
        {
            var users = await _userService.GetUsers();

            return Ok(users);
        }

        public async Task<IActionResult> SetAdmin()
        {
            //var roleList = await _roleManager.Roles.ToListAsync();

            //if (!roleList.Any(r => r.Name == UserConstants.Roles.Administrator)) return Redirect("/");

            //var userForAdmin = await _userService.GetUsers();

            //var user = await _userManager.FindByEmailAsync(userForAdmin.First().Email);
            //await _userManager.AddToRoleAsync(user, UserConstants.Roles.Administrator);

            return Ok();
        }

        public async Task<IActionResult> CreateRole()
        {
            //await _roleManager.CreateAsync(new IdentityRole { Name = UserConstants.Roles.Administrator});
            //await _roleManager.CreateAsync(new IdentityRole { Name = UserConstants.Roles.Author });
            //await _roleManager.CreateAsync(new IdentityRole { Name = UserConstants.Roles.User });
            //await _roleManager.CreateAsync(new IdentityRole { Name = UserConstants.Roles.Guest });
            return Ok();
        }

    }
}
