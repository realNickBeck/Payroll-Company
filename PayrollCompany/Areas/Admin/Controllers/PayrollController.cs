using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PayrollCompany.Models;
using System.Collections.Generic;
using System.Linq;

namespace PayrollCompany.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PayrollController : Controller
    {
        private PayrollContext context;
        private List<Employee> employees;

        public PayrollController(PayrollContext ctx)
        {
            context = ctx;
            employees = context.Employee.OrderBy(e => e.EmployeeID).ToList();
        }
        public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        [Route("[area]/Payroll/{id?}")]
        public IActionResult List(string id = "All")
        {
            List<Payroll> payroll;
            if (id == "All")
            {
                payroll = context.Payroll.OrderBy(p => p.PayrollID).ToList();
            }
            else
            {
                payroll = context.Payroll.Where(p => p.Employee.LastName == id).OrderBy(b => b.PayrollID).ToList();
            }
            ViewBag.Employee = employees;
            ViewBag.SelectedEmployeeName = id;

            return View(payroll);
        }

        [HttpGet]
        public IActionResult Add()
        {
            Payroll payroll = new Payroll();
            payroll.Employee = context.Employee.Find(1);

            ViewBag.Action = "Add";
            ViewBag.Employee = employees;
            return View("AddUpdate", payroll);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Payroll payroll = context.Payroll.Include(e => e.Employee).FirstOrDefault(e => e.PayrollID == id);

            ViewBag.Action = "Update";
            ViewBag.Employee = employees;

            return View("AddUpdate", payroll);
        }
        [HttpPost]
        public IActionResult Update(Payroll payroll)
        {
            if (ModelState.IsValid)
            {
                if (payroll.PayrollID == 0)
                {
                    context.Payroll.Add(payroll);
                }
                else
                {
                    context.Payroll.Update(payroll);
                }
                context.SaveChanges();
                return RedirectToAction("List");
            }
            else
            {
                ViewBag.Action = "Update";
                ViewBag.Employee = employees;
                return View("AddUpdate", payroll);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Payroll payroll = context.Payroll.Find(id);
            return View(payroll);
        }
        [HttpPost]
        public IActionResult Delete (Payroll payroll)
        {
            context.Payroll.Remove(payroll);
            context.SaveChanges();
            return RedirectToAction("List");
        }

    }
}
