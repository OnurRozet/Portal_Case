using Microsoft.AspNetCore.Mvc;

namespace CoffeeAppMVC.Controllers
{
    public class ChoiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
