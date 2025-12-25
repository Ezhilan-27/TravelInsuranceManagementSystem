using Microsoft.AspNetCore.Mvc;

namespace TravelInsuranceManagementSystem.Application.Controllers
{
    public class AdminController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Dashboard() => View();
        public IActionResult Policies() => View();
        public IActionResult Claims() => View();
        public IActionResult Payments() => View();

    }
}
