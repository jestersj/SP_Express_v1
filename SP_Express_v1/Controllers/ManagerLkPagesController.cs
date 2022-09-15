using Microsoft.AspNetCore.Mvc;
using SP_Express_v1.Models;
using System.Diagnostics;

namespace SP_Express_v1.Controllers
{
    public class ManagerLkPages : Controller
    {
        private readonly ILogger<ManagerLkPages> _logger;

        public ManagerLkPages(ILogger<ManagerLkPages> logger)
        {
            _logger = logger;
        }
        public IActionResult ManagerLk()
        {
            return View();
        }

        public IActionResult Assignment()
        {
            return View();
        }
        public IActionResult Contract()
        {
            return View();
        }
        public IActionResult CompaniesAddresses()
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