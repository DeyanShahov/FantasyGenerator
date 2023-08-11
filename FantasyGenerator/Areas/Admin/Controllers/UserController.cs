using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
//using System.Web.Mvc;
using FantasyGenerator.Core.Constants;
using FantasyGenerator.Core.Contracts;
using FantasyGenerator.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

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

            //if (await _userService.UpdateUser(model)) //ViewData[MessageConstant.SuccessMessage] = "Uspeshen zapis!";
            //{
            //    ViewData[MessageConstant.SuccessMessage] = "Uspeshen zapis!";
                
            //    //ModelState.Clear();

            //    //return RedirectToAction("Edit");
            //}
            //else ViewData[MessageConstant.ErrorMessage] = "Vaznikna greshka!";

            return View(model);
        }

        public async Task<IActionResult> Roles(string id)
        {
            //var roleList = await _roleManager.Roles.ToListAsync();
            var user = await _userService.GetUserById(id);
            var model = new UserRolesViewModel()
            {
                UserId = user.Id,
                Email = user.Email,
            };

            ViewBag.RoleItems = _roleManager.Roles
                .ToList()
                .Select(r => new SelectListItem()
                {
                    Text = r.Name,
                    Value = r.Id,
                    Selected = _userManager.IsInRoleAsync(user, r.Name).Result
                });

            return View(model);
        }

        public async Task<IActionResult> CreateRole()
        {
            //await _roleManager.CreateAsync(new IdentityRole { Name = "Administrator" });
            //await _roleManager.CreateAsync(new IdentityRole { Name = "User" });
            //await _roleManager.CreateAsync(new IdentityRole { Name = "Guest" });
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
