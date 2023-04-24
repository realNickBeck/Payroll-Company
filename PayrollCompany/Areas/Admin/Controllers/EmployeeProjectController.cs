using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PayrollCompany.Models;
using System.Collections.Generic;
using System.Linq;

namespace PayrollCompany.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmployeeProjectController : Controller
    {
        private PayrollContext context;
        private List<Employee> employees;
        private List<Project> projects;

        public EmployeeProjectController(PayrollContext ctx)
        {
            context = ctx;
            employees = context.Employee.OrderBy(c => c.EmployeeID).ToList();
            projects = context.Project.OrderBy(c => c.ProjectID).ToList();
        }
        public IActionResult Index()
        {
            return View("List");
        }

        [Route("[area]/EmployeeProject/{id?}")]
        public IActionResult List(string id = "All")
        {
            List<EmployeeProject> employeeProjects;
            if (id == "All")
            {
                employeeProjects = context.EmployeeProject.OrderBy(p => p.EmployeeProjectID).ToList();
            }
            else
            {
                employeeProjects = context.EmployeeProject.Where(p => p.Project.ProjectName == id).OrderBy(p=>p.EmployeeProjectID).ToList();
            }

            ViewBag.Project = projects;
            ViewBag.SelectedProjectName = id;
            return View(employeeProjects);

        }

        [HttpGet]
        public IActionResult Assign()
        {
            EmployeeProject employeeProject = new EmployeeProject();
            //employeeProject.Employee = context.Employee.Find(1);
            //employeeProject.Project = context.Project.Find(1);

            ViewBag.Employee = employees;
            ViewBag.Project = projects;
            ViewBag.Action = "Assign";
            return View("Assign", new EmployeeProject());

        }
        [HttpPost]
        public IActionResult Assign(EmployeeProject employeeProject)
        {
            if (ModelState.IsValid)
            {
                if (employeeProject.EmployeeProjectID == 0)
                {
                    context.EmployeeProject.Add(employeeProject);
                }
                context.SaveChanges();
                return RedirectToAction("List");
            }
            else
            {
                ViewBag.Employee = employees;
                ViewBag.Project = projects;
                ViewBag.Action = "Assign";
                return View("Assign", employeeProject);
            }
        }

        [HttpGet]
        public IActionResult Deassign(int id)
        {
            EmployeeProject employeeProject = context.EmployeeProject.Find(id);
            return View(employeeProject);
        }

        [HttpPost]
        public IActionResult Deassign(EmployeeProject employeeProject)
        {
            context.EmployeeProject.Remove(employeeProject);
            context.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
