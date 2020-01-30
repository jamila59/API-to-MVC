using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
  public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var allAnimals = Animal.GetAnimals();
            return View(allAnimals);
        }
    }
}