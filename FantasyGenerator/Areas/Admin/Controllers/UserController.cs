using FantasyGenerator.Core.Constants;
using FantasyGenerator.Core.Contracts;
using FantasyGenerator.Core.Models;
using FantasyGenerator.Core.Services;
using FantasyGenerator.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FantasyGenerator.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {
        private readonly RoleManager<IdentityRole> roleManager;

        private readonly UserManager<IdentityUser> userManager;

        private readonly IUserService userService;

        private readonly IRaceService raceService;

        private readonly IProfessionService professionService;

        private readonly INpcService npcService;

        public UserController(RoleManager<IdentityRole> roleManager
            , IUserService userService, UserManager<IdentityUser> userManager
            , IRaceService raceService, IProfessionService professionService
            , INpcService npcService)
        {
            this.roleManager = roleManager;
            this.userService = userService;
            this.userManager = userManager;
            this.raceService = raceService;
            this.professionService = professionService;
            this.npcService = npcService;
        }

        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> ManageUsers()
        {
            var users = await userService.GetUsers();

            return View(users);
        }

        public async Task<IActionResult> Edit(string id)
        {
            var model = await userService.GetUsersForEdit(id);

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
            var user = await userService.GetUserById(id);
            var model = new UserRolesViewModel()
            {
                UserId = user.Id,
                Email = user.Email,
            };

            ViewBag.RoleItems = roleManager.Roles
                .ToList()
                .Select( r => new SelectListItem()
                {
                    Text = r.Name,
                    Value = r.Id,
                    Selected =  userManager.IsInRoleAsync(user, r.Name).Result
                });

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Roles(UserRolesViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var user = await userService.GetUserById(model.UserId);
            var userRoles = await userManager.GetRolesAsync(user);
            await userManager.RemoveFromRolesAsync(user, userRoles);
            if (model.RoleIds?.Length > 0) 
            {
                var roles = await roleManager.Roles.Where(r => model.RoleIds.Contains(r.Id)).Select(r => r.Name).ToListAsync();

                await userManager.AddToRolesAsync(user, roles);
            }
            return RedirectToAction(nameof(ManageUsers));
        }

        public async Task<IActionResult> ShowAllRaces()
        {
            try
            {
                var races = await raceService.GetAllRaces();

                return View(races);
            }
            catch (Exception ex)
            {
                var errorModel = new ErrorViewModel { RequestId = ex.Message };

                return View("Error", errorModel);
            }
        }

        public async Task<IActionResult> DeleteRace(string raceId)
        {
            try
            {
                if (await raceService.DeleteRace(raceId))
                {
                    ViewData["OK"] = ErrorMessages.DB_SAVE_OK;
                }
                else
                {
                    ViewData["ERROR"] = ErrorMessages.DB_ERROR;
                }

                return RedirectToAction(nameof(ShowAllRaces), "Race", new { area = "" });
            }
            catch (Exception ex)
            {
                var errorModel = new ErrorViewModel { RequestId = ex.Message };

                return View("Error", errorModel);
            }
        }

        public async Task<IActionResult> ShowAllProfession()
        {
            try
            {
                var prof = await professionService.GetAllProfession();

                return View(prof);
            }
            catch (Exception ex)
            {
                var errorModel = new ErrorViewModel { RequestId = ex.Message };

                return View("Error", errorModel);
            }
        }

        public async Task<IActionResult> DeleteProfession(string professionId)
        {
            try
            {
                if (await professionService.DeleteProfession(professionId))
                {
                    ViewData["OK"] = ErrorMessages.DB_SAVE_OK;
                }
                else
                {
                    ViewData["ERROR"] = ErrorMessages.DB_ERROR;
                }

                return RedirectToAction(nameof(ShowAllProfession), "Profession", new { area = "" });
            }
            catch (Exception ex)
            {
                var errorModel = new ErrorViewModel { RequestId = ex.Message };

                return View("Error", errorModel);
            }
        }

        public async Task<IActionResult> ShowAllNpc()
        {
            try
            {
                var npcList = await npcService.GetAllNpc();

                return View(npcList);
            }
            catch (Exception ex)
            {
                var errorModel = new ErrorViewModel { RequestId = ex.Message };

                return View("Error", errorModel);
            }
        }

        public async Task<IActionResult> DeleteNpc(string npcId)
        {
            try
            {
                if (await npcService.DeleteNpc(npcId))
                {
                    ViewData["OK"] = ErrorMessages.DB_SAVE_OK;
                }
                else
                {
                    ViewData["ERROR"] = ErrorMessages.DB_ERROR;
                }

                return RedirectToAction(nameof(ShowAllNpc), "Npc", new { area = "" });
            }
            catch (Exception ex)
            {
                var errorModel = new ErrorViewModel { RequestId = ex.Message };

                return View("Error", errorModel);
            }
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
