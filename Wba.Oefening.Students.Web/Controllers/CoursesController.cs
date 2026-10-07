using Microsoft.AspNetCore.Mvc;
using Wba.Oefening.Students.Core.Repositories;
using Wba.Oefening.Students.Web.ViewModels;

namespace Wba.Oefening.Students.Web.Controllers
{
    public class CoursesController : Controller
    {
        private readonly CourseRepository _courseRepository = new();


        //shows a list of courses
        public IActionResult Index()
        {
            //get the courses
            var courses = _courseRepository.Courses;
            //fill the viewmodel
            var coursesIndexViewModel = new CoursesIndexViewModel
            {
                PageTitle = "Our courses",
                Courses = courses.Select(c => new BaseViewModel
                {
                    Id = c.Id,
                    Value = c.Name
                })
            };
            return View(coursesIndexViewModel);
        }
    }
}
