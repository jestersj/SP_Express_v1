using Microsoft.AspNetCore.Mvc;
using SP_Express_v1.Models;
using System.Diagnostics;
using SP_Express_v1.DB.Concrete;
using SP_Express_v1.DB.Contract;

namespace SP_Express_v1.Controllers
{
    public class UserLkPages : Controller {
    
        private readonly IDbSelect _select;
        private readonly IDbInsert _insert;
        private readonly IDbUpdate _update;

        public UserLkPages(
            IDbSelect select,
            IDbInsert insert,
            IDbUpdate update
        )
        {
            _select = select;
            _insert = insert;
            _update = update;
        }
        
        public IActionResult UserLk()
        {
            return View();
        }

        public IActionResult AgmLk()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Invoice()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Invoice(Address model)
        {
            _insert.InsertConsignment(model);
            return View(model);
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