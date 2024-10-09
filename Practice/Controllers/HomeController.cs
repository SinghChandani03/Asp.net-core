
using Microsoft.AspNetCore.Mvc;

namespace Practice.Controllers
{
    //[Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        //[Route("/")]
        //[Route("~/")]
        //[Route("~/Home")]

        public IActionResult Index()
        {
            ViewData["name"] = "Chandani";
            ViewBag.name = "Chandani";
            TempData["name3"] = "Chandani";

            TempData.Keep();
            return View();
        }

        public IActionResult About()
        {
            TempData.Keep("name3");
            return View();
        }

        //[Route("{id?}")]
        public int Details(int? id)
        {
            return id ?? 1;
        }
    }

}

//To change name of cotroller and views
//public class HomeController1 : Controller
//{
//    [Route("/")]
//    [Route("/Home")]
//    [Route("/Home/Index")]

//    public IActionResult Data()
//    {
//        return View("~/Views/Home/Index.cshtml");
//    }
//}