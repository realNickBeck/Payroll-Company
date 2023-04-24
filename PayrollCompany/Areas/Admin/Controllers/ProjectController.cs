using Microsoft.AspNetCore.Mvc;
using PayrollCompany.Models;
using System.Collections.Generic;
using System.Linq;

namespace PayrollCompany.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProjectController : Controller
    {
        private PayrollContext context;

        public ProjectController(PayrollContext ctx)
        {
            context = ctx;

        }
        public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        [Route("[area]/Project/{id?}")]
        public IActionResult List()
        {
            var projects = context.Project
                .OrderBy(c => c.ProjectID).ToList();
            return View(projects);
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("AddUpdate", new Project());
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewBag.Action = "Update";
            Project project = context.Project.Find(id);
            return View("AddUpdate", project);
        }

        [HttpPost]
        public IActionResult Update(Project project)
        {
            if (ModelState.IsValid)
            {
                if (project.ProjectID == 0)
                {
                    context.Project.Add(project);
                }
                else
                {
                    context.Project.Update(project);
                }
                context.SaveChanges();
                return RedirectToAction("List");
            }
            else
            {
                ViewBag.Action = "Save";
                return View("AddUpdate");
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Project project = context.Project.Find(id);
            return View(project);
        }


        [HttpPost]
        public IActionResult Delete(Project project)
        {
            context.Project.Remove(project);
            context.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
