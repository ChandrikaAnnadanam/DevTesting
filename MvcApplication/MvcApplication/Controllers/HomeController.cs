using Microsoft.AspNetCore.Mvc;
using MvcApplication.Models;
using System.Diagnostics;

namespace MvcApplication.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            var student = new Student();
            student.Id = 1;
            student.Name = "ram";
            return View(student);
        }
        public IActionResult AddStudent(int id)
        {
            try
            {
                var student = new Student();
                student.Id = id;
                student.Name = "ram";
                return View(student);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
         
            return View(student);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
