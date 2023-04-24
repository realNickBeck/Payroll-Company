using Microsoft.AspNetCore.Mvc;

namespace PayrollCompany.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Account()
        {
            return View("Account");
        }

        public IActionResult Leave()
        {
            return View("Leave");
        }

        public IActionResult Payroll()
        {
            return View("Payroll");
        }

        public IActionResult Timesheet()
        {
            return View("Timesheet");
        }

        public IActionResult RequestTime()
        {
            return View("RequestTime");
        }

    }
}
