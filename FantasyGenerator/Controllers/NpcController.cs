using FantasyGenerator.Core.Contracts;
using FantasyGenerator.Core.Models.Npc;
using FantasyGenerator.Models;
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
                return RedirectToAction(nameof(ShowAllNpc));
            }

            //var errorModel = new ErrorViewModel { RequestId = isError };

            //return View("Error", errorModel);

            ModelState.AddModelError("", isError);
            return View();
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

        public async Task<IActionResult> ShowMyNpc(string userId)
        {
            //var userId = Request.Query["userId"];         
            try
            {
                var npc = await npcService.GetMyNpc(userId);

                return View(npc);
            }
            catch (Exception ex)
            {
                var errorModel = new ErrorViewModel { RequestId = ex.Message };

                return View("Error", errorModel);
            }
        }

        public async Task<IActionResult> ShowFullNpcDescriptions(string npcId)
        {
            var npc = await npcService.NpcDetails(npcId);

            return View(npc);
        }

        public async Task<IActionResult> EditNpc(string npcId)
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

            var model = await npcService.GetNpcForEdit(npcId);

            return View(model);
        }
    }
}
