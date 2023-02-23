using DAL.Data;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace DAL.Controllers
{
    public class CrudController : Controller
    { private readonly Application_db_context _db;
        public CrudController(Application_db_context db) {
            _db = db;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(std_details obj)
        {
            _db.std_Detail.Add(obj);
            _db.SaveChanges();
       
            return View();
        }
        public IActionResult Index()
        {
            IEnumerable<std_details> obj = _db.std_Detail;
            return View(obj);
        }
      
        public IActionResult Edit(int id)
        {
            var obj=_db.std_Detail.Find(id);
            if(obj!=null) { 
            return View(obj);   
            }
            else {
                return NotFound();
            }
           
        }
        public IActionResult Update(std_details obj)
        { if (obj != null)
            {   _db.std_Detail.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return NotFound();  
            }
        }
        public IActionResult Delete(int id)
        {
            var obj = _db.std_Detail.Find(id);
            // ;
            if (obj != null)
            {
                _db.std_Detail.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return NotFound(); 
            }
        }
    }
}
