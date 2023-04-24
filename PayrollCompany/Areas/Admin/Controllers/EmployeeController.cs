using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PayrollCompany.Models;
using System.Collections.Generic;
using System.Linq;

namespace PayrollCompany.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmployeeController : Controller
    {
        private PayrollContext context;
        private List<Department> department;

        public EmployeeController(PayrollContext ctx)
        {
            context = ctx;
            department = context.Department.OrderBy(d => d.DepartmentID).ToList();
        }

        public IActionResult Index()
        {
            return View("List");
        }

        [Route("[area]/Employee/{id?}")]
        public IActionResult List(string id = "All")
        {
            List<Employee> employees;
            if (id == "All")
            {
                employees = context.Employee
                    .OrderBy(p => p.EmployeeID).ToList();
            }
            else
            {
                employees = context.Employee
                    .Where(p => p.Department.DepartmentName == id)
                    .OrderBy(p => p.EmployeeID).ToList();
            }

            // use ViewBag to pass department data to view
            ViewBag.Department = department;
            ViewBag.SelectedDepartmentName = id;

            // bind products to view
            return View(employees);
        }

        [HttpGet]
        public IActionResult Add()
        {
            //creates a new employee
            Employee employee = new Employee();
            employee.Department = context.Department.Find(1);

            ViewBag.Action = "Register";
            ViewBag.Department = department; 
            return View("AddUpdate", employee);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Employee employee = context.Employee.Include(e => e.Department).FirstOrDefault(e => e.EmployeeID == id);

            ViewBag.Action = "Modify";
            ViewBag.Department = department;

            return View("AddUpdate", employee);
        }
        [HttpPost]
        public IActionResult Update(Employee employee)
        {
            if (ModelState.IsValid)
            {
                if (employee.EmployeeID == 0)
                {
                    context.Employee.Add(employee);
                }
                else
                {
                    context.Employee.Update(employee);
                }
                context.SaveChanges();
                return RedirectToAction("List");
            }
            else
            {
                ViewBag.Action = "Modify";
                ViewBag.Department = department;
                return View("AddUpdate", employee);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Employee employee = context.Employee.Find(id);
            return View(employee);
        }
        [HttpPost]
        public IActionResult Delete(Employee employee)
        {
            context.Employee.Remove(employee);
            context.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
