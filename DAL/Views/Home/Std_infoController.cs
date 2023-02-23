using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace DAL.Views.Home
{
    public class Std_infoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
