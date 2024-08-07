using System.Diagnostics;
using EmployeeData.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeData.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1,Name="emp1",TotalTimeWorked=200},
                new Employee { Id = 1,Name="emp2",TotalTimeWorked=300},
                 new Employee { Id = 1,Name="emp2",TotalTimeWorked=90}
            };
            ViewBag.employees = employees;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
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
