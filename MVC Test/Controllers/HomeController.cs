using Microsoft.AspNetCore.Mvc;
using MVC_Test.Models;
using MVC_Test.Repository;
using System.Diagnostics;

namespace MVC_Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepository _studentRepository;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository = new StudentRepository();
        }
        public List<StudentModel> getAllStudents() 
        {
            return _studentRepository.getAllStudents();
        }

        public StudentModel getStudent(int id)
        {
            return _studentRepository.getStudentById(id);
        }

        public IActionResult Index()
        {
            //var students = new List<StudentModel>
            //{
            //    new StudentModel { Rollno = 1, Name = "chandani"},
            //    new StudentModel { Rollno = 2, Name = "Suraj"}
            //};
            //ViewData["student"]=students;
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
    }
}
