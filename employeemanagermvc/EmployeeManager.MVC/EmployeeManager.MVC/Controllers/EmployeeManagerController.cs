using EmployeeManager.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeeManager.MVC.Controllers
{
    public class EmployeeManagerController : Controller
    {
        private AppDbContext db;
        public EmployeeManagerController(AppDbContext _db)
        {
            this.db = _db;   
        }
        private void FillCountries()
        {
            List<SelectListItem> countries =
             (from c in db.Countries
              orderby c.Name ascending
              select new SelectListItem()
              { Text = c.Name, Value = c.Name }
              ).ToList();
            ViewBag.Countries = countries;
        }
        public IActionResult List()
        {
            List<Employee> model = (from e in db.Employees
                                    orderby e.EmployeeID
                                    select e
                                    ).ToList();
            return View(model);
        }
   

    }
}
