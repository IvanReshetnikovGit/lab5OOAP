// Controllers/VendingMachineController.cs
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class VendingMachineController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(decimal insertedMoney, decimal itemPrice)
        {
            var vendingMachine = new VendingMachineContext();
            var result = vendingMachine.Process(insertedMoney, itemPrice);
            ViewBag.Result = result;
            return View();
        }
    }
}
