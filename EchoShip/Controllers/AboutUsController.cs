using Microsoft.AspNetCore.Mvc;

namespace EchoShip.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
