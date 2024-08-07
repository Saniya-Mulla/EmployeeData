using EmployeeData.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeData.Controllers
{
    public class EmployeeDataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult EmployeeDetails()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1,Name="emp1",TotalTimeWorked=200},
                new Employee { Id = 1,Name="emp2",TotalTimeWorked=300}
            };

            return Json(employees.ToList().Take(10));
        }
    }
}
