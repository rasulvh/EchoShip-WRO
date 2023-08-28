using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EchoShip.Controllers
{
    [Authorize]
    public class MapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
