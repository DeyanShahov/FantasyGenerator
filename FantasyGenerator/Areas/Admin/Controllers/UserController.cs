using FantasyGenerator.Core.Contracts;
using FantasyGenerator.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FantasyGenerator.Areas.Admin.Controllers
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


        public async Task<IActionResult> ManageUsers()
        {
            var users = await _userService.GetUsers();

            return View(users);
        }

        public async Task<IActionResult> Edit(string id)
        {
            var model = await _userService.GetUsersForEdit(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UserEditViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            return View(model);
        }

        public async Task<IActionResult> Roles(string id)
        {
            var user = await _userService.GetUserById(id);
            var model = new UserRolesViewModel()
            {
                UserId = user.Id,
                Email = user.Email,
            };

            ViewBag.RoleItems = _roleManager.Roles
                .ToList()
                .Select( r => new SelectListItem()
                {
                    Text = r.Name,
                    Value = r.Id,
                    Selected =  _userManager.IsInRoleAsync(user, r.Name).Result
                });

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Roles(UserRolesViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var user = await _userService.GetUserById(model.UserId);
            var userRoles = await _userManager.GetRolesAsync(user);
            await _userManager.RemoveFromRolesAsync(user, userRoles);
            if (model.RoleIds?.Length > 0) 
            {
                var roles = await _roleManager.Roles.Where(r => model.RoleIds.Contains(r.Id)).Select(r => r.Name).ToListAsync();

                await _userManager.AddToRolesAsync(user, roles);
            }
            return RedirectToAction(nameof(ManageUsers));
        }

        public async Task<IActionResult> CreateRole()
        {
            //await _roleManager.CreateAsync(new IdentityRole { Name = UserConstants.Roles.Administrator});
            //await _roleManager.CreateAsync(new IdentityRole { Name = UserConstants.Roles.Author });
            //await _roleManager.CreateAsync(new IdentityRole { Name = UserConstants.Roles.User });
            //await _roleManager.CreateAsync(new IdentityRole { Name = UserConstants.Roles.Guest });
            return Ok();
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
    }
}
