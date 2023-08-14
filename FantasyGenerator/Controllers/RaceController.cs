using FantasyGenerator.Core.Contracts;
using FantasyGenerator.Core.Models.Race;
using FantasyGenerator.Models;
using Microsoft.AspNetCore.Mvc;

namespace FantasyGenerator.Controllers
{
    public class RaceController : BaseController
    {
        private readonly IRaceService _roleService;

        public RaceController(IRaceService roleService)
        {
            _roleService = roleService;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
        public async Task<IActionResult> CreateNewRace()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> CreateNewRace(RaceCreateViewModel model)
        {

            //string isError = productService.Create(model);

            //if (isError == null) return Redirect("/");

            //return View(new { ErrorMessage = isError }, "/Error");

            string isError = await _roleService.CreateNewRace(model);

            if (isError == null) return RedirectToAction(nameof(CreateNewRace)); //return Redirect("/");


            var errorModel = new ErrorViewModel
            {
                RequestId = isError               
            };

            return View("Error", errorModel);


            //try
            //{
            //    await _roleService.CreateNewRace(model);
            //}
            //catch (Exception e)
            //{
            //    return BadRequest(e.Message);
            //}

            //return Ok();
        }
    }
}
