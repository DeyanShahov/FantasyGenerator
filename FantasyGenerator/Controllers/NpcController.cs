using FantasyGenerator.Core.Constants;
using FantasyGenerator.Core.Contracts;
using FantasyGenerator.Core.Models.Npc;
using FantasyGenerator.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text;

namespace FantasyGenerator.Controllers
{
    public class NpcController : BaseController
    {
        private readonly INpcService npcService;

        //private readonly NpcService npcService;

        private readonly IRaceService raceService;

        private readonly IProfessionService professionService;

        private readonly UserManager<IdentityUser> userManager;


        public NpcController(UserManager<IdentityUser> userManager
            , IRaceService raceService, IProfessionService professionService, INpcService npcService)
        {
            this.userManager = userManager;
            this.raceService = raceService;
            this.professionService = professionService;
            this.npcService = npcService;
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
                return RedirectToAction(nameof(ShowMyNpc), new { userId = userId });
                //return RedirectToAction(nameof(ShowMyNpc));
            }

            //var errorModel = new ErrorViewModel { RequestId = isError };

            //return View("Error", errorModel);

            ModelState.AddModelError("", isError);
            return View();
        }

        public async Task<IActionResult> CreateNewNpcName()
        {
            var informaciq = ViewData.ContainsKey(MessageConstant.ErrorMessage);
            var info = ViewData[MessageConstant.ErrorMessage];

            var racesList = await raceService.GetAllRaces();            

            ViewBag.RaseItems = racesList
                .Select(r => new SelectListItem()
                {
                    Text = r.Name,
                    Value = r.Id,
                });

            var namesList = await npcService.GetAllNpcNames();

            ViewBag.NpcNames = namesList;

            if (TempData.ContainsKey(MessageConstant.ErrorMessage))
            {
                ViewData[MessageConstant.ErrorMessage] = TempData[MessageConstant.ErrorMessage];
                TempData.Remove(MessageConstant.ErrorMessage);
            }


            if (TempData.ContainsKey(MessageConstant.SuccessMessage))
            {
                ViewData[MessageConstant.SuccessMessage] = TempData[MessageConstant.SuccessMessage];
                TempData.Remove(MessageConstant.SuccessMessage);
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewNpcName(NpcNameCreateViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var namesFromModel = model.Name.Split(',');

            string allNpcNames = await npcService.GetAllNpcNames();

            StringBuilder duplicateNames = new StringBuilder();
            StringBuilder uniqueNames = new StringBuilder();

            foreach (var name in namesFromModel)
            {
                if (allNpcNames.Contains(name)) duplicateNames.Append(name).Append(", ");
                else uniqueNames.Append(name).Append(", ");
            }

            if (!string.IsNullOrEmpty(duplicateNames.ToString()))
            {
                var newString = duplicateNames.ToString().Substring(0,duplicateNames.Length - 2).Trim();
                TempData["ErrorMessage"] = $"{newString} already exists.";
            }

            if (!string.IsNullOrEmpty(uniqueNames.ToString()))
            {
                var newString = uniqueNames.ToString().Substring(0, uniqueNames.Length - 2).Trim();
                TempData["SuccessMessage"] = $"{newString} is successful addet to DB.";
            }

            model.Name = uniqueNames.ToString().Trim();

            string isError = await npcService.AddNewNpcName(model);

            if (isError == null) return RedirectToAction(nameof(CreateNewNpcName), model);

            ModelState.AddModelError("", isError);
            return RedirectToAction(nameof(CreateNewNpcName), model);
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

        [HttpPost]
        public async Task<IActionResult> EditNpc(NpcEditViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            try
            {
                if (await npcService.UpdateNpc(model))
                {
                    ViewData["OK"] = ErrorMessages.DB_SAVE_OK;
                }
                else
                {
                    ViewData["ERROR"] = ErrorMessages.DB_ERROR;
                }

                return RedirectToAction(nameof(ShowMyNpc), new { userId = model.AuthorId });
            }
            catch (Exception ex)
            {
                var errorModel = new ErrorViewModel { RequestId = ex.Message };

                return View("Error", errorModel);
            }
        }
    }
}
