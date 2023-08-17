using FantasyGenerator.Core.Contracts;
using FantasyGenerator.Core.Models.Npc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FantasyGenerator.Controllers
{
    public class NpcController : BaseController
    {
        private readonly INpcService npcService;

        private readonly IRaceService raceService;

        private readonly IProfessionService professionService;

        private readonly UserManager<IdentityUser> userManager;

        public NpcController(INpcService npcService, UserManager<IdentityUser> userManager
            , IRaceService raceService, IProfessionService professionService)
        {
            this.npcService = npcService;
            this.userManager = userManager;
            this.raceService = raceService;
            this.professionService = professionService;
        }

        public async Task<IActionResult> CreateNewNpc()
        {
            var racesList = await raceService.GetAllRaces();

            ViewBag.RaseItems = racesList
                .Select(r => new SelectListItem()
                {
                    Text = r.Name,
                    Value = r.Id,
                });

            var professionList = await professionService.GetAllProfession();

            ViewBag.ProfessionItems = professionList
                .Select(p => new SelectListItem()
                {
                    Text = p.Name,
                    Value = p.Id,
                });

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewNpc(NpcCreateViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var userId = (await userManager.FindByNameAsync(User.Identity?.Name))?.Id;

            string isError = await npcService.CreateNewNpc(model, userId);

            if (isError == null)
            {
                //return RedirectToAction(nameof(ShowMyProfession), new { userId = userId });
                return View();
            }

            //var errorModel = new ErrorViewModel { RequestId = isError };

            //return View("Error", errorModel);

            ModelState.AddModelError("", isError);
            return View();
        }
    }
}
