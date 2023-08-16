using FantasyGenerator.Core.Constants;
using FantasyGenerator.Core.Contracts;
using FantasyGenerator.Core.Models.Race;
using FantasyGenerator.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FantasyGenerator.Controllers
{
    public class RaceController : BaseController
    {
        private readonly IRaceService _raceService;
        private readonly UserManager<IdentityUser> _userManager;

        public RaceController(IRaceService raceService, UserManager<IdentityUser> userManager)
        {
            _raceService = raceService;
            _userManager = userManager;
        }

        public async Task<IActionResult> CreateNewRace()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> CreateNewRace(RaceCreateViewModel model)
        {
            var userId = (await _userManager.FindByNameAsync(User.Identity?.Name))?.Id;

            string isError = await _raceService.CreateNewRace(model, userId);

            if (isError == null) 
            {
                return RedirectToAction(nameof(ShowMyRaces), new { userId = userId});
            }

            var errorModel = new ErrorViewModel
            {
                RequestId = isError               
            };

            return View("Error", errorModel);
        }


        public async Task<IActionResult> ShowAllRaces()
        {          
            try
            {
                var races = await _raceService.GetAllRaces();

                return View(races);
            }
            catch (Exception ex)
            {
                var errorModel = new ErrorViewModel { RequestId = ex.Message };

                return View("Error", errorModel);
            }
        }


        public async Task<IActionResult> ShowMyRaces(string userId)
        {
            //var userId = Request.Query["userId"];         
            try
            {
                var races = await _raceService.GetMyRaces(userId);

                return View(races);
            }
            catch (Exception ex)
            {
                var errorModel = new ErrorViewModel { RequestId = ex.Message };

                return View("Error", errorModel);
            }
        }

        public async Task<IActionResult> ShowFullRaceDescriptions(string raceId)
        {
            var race = await _raceService.RaceDetails(raceId);

            return View(race);
        }

        public async Task<IActionResult> EditRace(string raceId)
        {
            var model = await _raceService.GetRaceForEdit(raceId);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditRace(RaceEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                if (await _raceService.UpdateRace(model))
                {
                    ViewData["OK"] = ErrorMessages.DB_SAVE_OK;
                }
                else
                {
                    ViewData["ERROR"] = ErrorMessages.DB_ERROR;
                }

                return RedirectToAction(nameof(ShowMyRaces), new { userId = model.AuthorId });
            }
            catch (Exception ex)
            {
                var errorModel = new ErrorViewModel { RequestId = ex.Message };

                return View("Error", errorModel);
            }          
        }
    }
}

