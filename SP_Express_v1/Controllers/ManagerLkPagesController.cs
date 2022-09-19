using Microsoft.AspNetCore.Mvc;
using SP_Express_v1.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using SP_Express_v1.DB.Contract;

namespace SP_Express_v1.Controllers
{
    [Authorize(Roles = "adm")]
    public class ManagerLkPages : Controller
    {
        private readonly IDbSelect _select;
        private readonly IDbInsert _insert;
        private readonly IDbUpdate _update;

        public ManagerLkPages(
            IDbSelect select,
            IDbInsert insert,
            IDbUpdate update
        )
        {
            _select = select;
            _insert = insert;
            _update = update;
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
        
        [HttpGet]
        public IActionResult CreateInvoice()
        {
            
            return View();
        }
        
        [HttpPost]
        public IActionResult CreateInvoice(Consignment model)
        {
            _insert.InsertInvoice(model);
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
