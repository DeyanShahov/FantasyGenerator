using FantasyGenerator.Core.Contracts;
using FantasyGenerator.Core.Models.Profession;
using FantasyGenerator.Core.Models.Race;
using FantasyGenerator.Core.Services;
using FantasyGenerator.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FantasyGenerator.Controllers
{
    public class ProfessionController : BaseController
    {
        private readonly IProfessionService professionService;
        private readonly UserManager<IdentityUser> userManager;

        public ProfessionController(IProfessionService professionService, UserManager<IdentityUser> userManager)
        {
            this.professionService = professionService;
            this.userManager = userManager;
        }

        public async Task<IActionResult> CreateNewProfession()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewProfession(ProfessionCreateViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var userId = (await userManager.FindByNameAsync(User.Identity?.Name))?.Id;

            string isError = await professionService.CreateNewProfession(model, userId);

            if (isError == null)
            {
                return View();
            }

            var errorModel = new ErrorViewModel { RequestId = isError };

            return View("Error", errorModel);
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

    }
}
