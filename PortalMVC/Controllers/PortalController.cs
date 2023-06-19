using common.portal.com.Entity;
using common.portal.com.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeAppMVC.Controllers
{
    public class PortalController : Controller
    {
        IPortalService _portalService;

        public PortalController(IPortalService portalService)
        {
            _portalService = portalService;
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
            var addedCustomer = _portalService.SaveToDb(customer);
            TempData["Message"] = customer.FirstName;
            return RedirectToAction("Message");
        }

        public IActionResult Message()
        {

            return View();
        }
    }
}
