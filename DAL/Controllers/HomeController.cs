﻿using DAL.Data;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace DAL.Controllers
{
    public class HomeController : Controller
    { private readonly Application_db_context _db;
        public HomeController(Application_db_context db) {
            _db = db;
        }
        public IActionResult Index(User_Auth obj)
        {
             if (ModelState.IsValid)
            {
                bool user = _db.std_Detail.Any(c => c.email.Equals(obj.email) && c.password == obj.password);
                if (user.Equals(true))
                {
                    return RedirectToAction("Index", "Crud");
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return View();
            }
        }
        
      






    }
}
