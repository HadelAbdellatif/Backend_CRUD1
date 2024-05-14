using Department_task.Data;
using Department_task.Models;
using Microsoft.AspNetCore.Mvc;

namespace Department_task.Controllers
{
    public class DepartmentController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var department = context.Departments.ToList();
            return View("Index", department);
        }

        public IActionResult Details(int id) { 
            var department_details = context.Departments.Find(id);
            return View("Details", department_details);
        }

        public IActionResult Create()
        {
            return View("Create");
        }


        public IActionResult Store(Department department) {
            context.Departments.Add(department);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var department_id = context.Departments.Find(id);
            context.Departments.Remove(department_id);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
