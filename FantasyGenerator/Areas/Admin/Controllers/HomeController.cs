using Microsoft.AspNetCore.Mvc;

namespace FantasyGenerator.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
