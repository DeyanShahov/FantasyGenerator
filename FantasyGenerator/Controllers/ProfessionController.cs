using Microsoft.AspNetCore.Mvc;

namespace FantasyGenerator.Controllers
{
    public class ProfessionController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
