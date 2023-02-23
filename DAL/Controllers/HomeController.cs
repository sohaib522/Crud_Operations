using DAL.Data;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace DAL.Controllers
{
    public class HomeController : Controller
    { private readonly Application_db_context _db;
        public HomeController(Application_db_context db) {
            _db = db;
        } 
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(std_details obj)
            
        {
            var id = 3;
            var Email=_db.std_Detail.Find("sadia@gmail.com");
            //var password = _db.std_Detail.Find(obj.password);
            if (Email != null)
            {
                return RedirectToAction("Index", "Crud");

            }
            else
            {
                return NotFound();
            }
        }






    }
}
