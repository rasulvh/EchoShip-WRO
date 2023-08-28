using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EchoShip.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}