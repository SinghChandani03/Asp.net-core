using Microsoft.AspNetCore.Mvc;

namespace Practice.Controllers
{
    public class UserController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
