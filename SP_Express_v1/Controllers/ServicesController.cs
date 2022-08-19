using Microsoft.AspNetCore.Mvc;
using SP_Express_v1.Models;
using System.Diagnostics;

namespace SP_Express_v1.Controllers
{
    public class ServicesController : Controller
    {
        private readonly ILogger<ServicesController> _logger;

        public ServicesController(ILogger<ServicesController> logger)
        {
            _logger = logger;
        }
        public IActionResult Agm()
        {
            return View();
        }
        public IActionResult Express_russia()
        {
            return View();
        }

        public IActionResult Express_world()
        {
            return View();
        }
        public IActionResult Express()
        {
            return View();
        }
        public IActionResult Loaders()
        {
            return View();
        }
        public IActionResult Logistic()
        {
            return View();
        }
        public IActionResult Package()
        {
            return View();
        }
        public IActionResult Prepost()
        {
            return View();
        }
        public IActionResult Standart()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}