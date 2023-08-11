using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using FantasyGenerator.Core.Constants;
using Microsoft.AspNetCore.Authorization;
using FantasyGenerator.Core.Contracts;

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

        //[Authorize(Roles = UserConstants.Roles.Administrator)]
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
