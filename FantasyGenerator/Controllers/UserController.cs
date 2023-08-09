using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using FantasyGenerator.Core.Constants;


namespace FantasyGenerator.Controllers
{
    public class UserController : BaseController
    {

        private readonly RoleManager<IdentityRole> _roleManager;

        public UserController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager; 

        }
        public IActionResult Index()
        {
            return View();
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
