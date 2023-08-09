using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FantasyGenerator.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {

    }
}
