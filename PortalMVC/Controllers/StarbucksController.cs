using common.portal.com.Entity;
using common.portal.com.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeAppMVC.Controllers
{
    public class StarbucksController : Controller
    {
        IStarbucksService _starbucksService;

        public StarbucksController(IStarbucksService starbucksService)
        {
            _starbucksService = starbucksService;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult AddCustomer()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            var addedCustomer = _starbucksService.SaveToDb(customer);
            TempData["Message"] = customer.FirstName;
            return RedirectToAction("Message");
        }

        public IActionResult Message()
        {
          
            return View();
        }

    }
}
