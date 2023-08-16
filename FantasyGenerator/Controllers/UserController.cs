using FantasyGenerator.Core.Contracts;
using FantasyGenerator.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

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
            if (!ModelState.IsValid) return View(model);

            var user = await _userService.GetUserById(model.Id);

            if (user != null)
            {
                //user.UserName = "Petkan";
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
    }
}
