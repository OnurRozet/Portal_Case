using common.portal.com.Entity;
using common.portal.com.Interface;
using Microsoft.AspNetCore.Mvc;
using System;

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
           

            try
            {
                Customer addedCustomer = _portalService.SaveToDb(customer);
                TempData["Message"] = customer.FirstName;
                return RedirectToAction("Message");
            }
            catch (ApplicationException ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                TempData["Message"] = ex.Message;
                return RedirectToAction("ErrorMessage");
            }

           
        }

        public IActionResult Message()
        {

            return View();
        }

        public IActionResult ErrorMessage() 
        {
            return View();
        }
    }
}
