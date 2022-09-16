﻿using Microsoft.AspNetCore.Mvc;
using SP_Express_v1.Models;
using System.Diagnostics;
using SP_Express_v1.DB.Contract;

namespace SP_Express_v1.Controllers
{
    public class HomeController : Controller
    {
        private IDbSelect _repo;

        public HomeController(IDbSelect repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ExpressCalc()
        {
            return View();
        }
        public IActionResult Tracking()
        {
            return View();
        }
        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult Services_main()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult LKRedirection()
        {
            Console.WriteLine("123");
            if (User.IsInRole("adm"))
            {
                Console.WriteLine("456");
                return RedirectToAction("ManagerLk", "ManagerLkPages");
            }
            
            if (User.IsInRole("usr"))
            {
                Console.WriteLine("789");
                return RedirectToAction("UserLk", "UserLkPages");
            }

            return RedirectToAction("Login", "Account");
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ExpressCalc(Address model)
        {
            return PartialView(model);
            // if (ModelState.IsValid)
            // {
            //     if (model.Country == "Россия")
            //     {
            //         if (model.Region == "Москва")
            //         {
            //             model.Adress = model.PostIndex + " " + model.Town + " " + model.Street + " " + model.House;
            //         }
            //         else
            //         {
            //             model.Adress = model.PostIndex + " " + model.RegionFull + " " + model.Town + " " + model.Street + " " + model.House;
            //         }
            //     }
            //     else
            //     {
            //         model.Adress = model.Country + " " + model.Town + " " + model.Street + " " + model.House;
            //     }
            //
            //     if (!string.IsNullOrEmpty(model.Telefon))
            //     {
            //         model.Telefon = RemoveSpaces(model.Telefon);
            //     }
            //     _repo.InsertArdNew(model);
            //     return RedirectToAction("ListAdr");
            // }
            // return PartialView(model);
        }
    }
}