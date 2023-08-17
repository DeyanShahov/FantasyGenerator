using FantasyGenerator.Core.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FantasyGenerator.Controllers
{
    public class NpcController : BaseController
    {
        private readonly INpcService pcService;

        private readonly UserManager<IdentityUser> userManager;

        public NpcController(INpcService pcService, UserManager<IdentityUser> userManager)
        {
            this.pcService = pcService;
            this.userManager = userManager;
        }

        public async Task<IActionResult> CreateNewNpc()
        {
            return View();
        }
    }
}
