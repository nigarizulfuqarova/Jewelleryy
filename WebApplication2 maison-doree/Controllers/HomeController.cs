using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2_maison_doree.Models;

namespace WebApplication2_maison_doree.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
