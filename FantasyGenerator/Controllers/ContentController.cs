using Microsoft.AspNetCore.Mvc;

namespace FantasyGenerator.Controllers
{
    public class ContentController : BaseController
    {
        public IActionResult AddContent()
        {
            return View();
        }
    }
}
