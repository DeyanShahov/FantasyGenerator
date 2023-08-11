using FantasyGenerator.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FantasyGenerator.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        //public async Task<IActionResult> Index()
        //{
        //    var users = await _userService.GetUsers();

        //    //return View(users);
        //    return RedirectToAction("ManageUsers", "User");
        //}

        public async Task<IActionResult> ManageUsers()
        {
            var users = await _userService.GetUsers();

            return View(users);
        }
    }
}
