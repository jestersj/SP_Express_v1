using Microsoft.AspNetCore.Mvc;
using SP_Express_v1.Models;
using System.Diagnostics;

namespace SP_Express_v1.Controllers
{
    public class UserLkPages : Controller
    {
        private readonly ILogger<UserLkPages> _logger;

        public UserLkPages(ILogger<UserLkPages> logger)
        {
            _logger = logger;
        }
        
        public IActionResult UserLk()
        {
            return View();
        }

        public IActionResult AgmLk()
        {
            return View();
        }
        public IActionResult Invoice()
        {
            return View();
        }
        public IActionResult Settings()
        {
            return View();
        }
        public IActionResult Registries()
        {
            return View();
        }
        public IActionResult Departures()
        {
            return View();
        }
        public IActionResult Operations()
        {
            return View();
        }
        public IActionResult AddressBook()
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