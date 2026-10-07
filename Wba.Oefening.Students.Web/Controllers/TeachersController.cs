using Microsoft.AspNetCore.Mvc;

namespace Wba.Oefening.Students.Web.Controllers
{
    public class TeachersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
