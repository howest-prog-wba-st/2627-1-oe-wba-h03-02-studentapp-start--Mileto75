using Microsoft.AspNetCore.Mvc;

namespace Wba.Oefening.Students.Web.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
