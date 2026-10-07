using Microsoft.AspNetCore.Mvc;
using Wba.Oefening.Students.Core.Repositories;
using Wba.Oefening.Students.Web.ViewModels;

namespace Wba.Oefening.Students.Web.Controllers
{
    public class CoursesController : Controller
    {
        private readonly CourseRepository _courseRepository = new();
        private readonly StudentRepository _studentRepository = new();


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
        public IActionResult Students(int courseId)
        {
            //Get course with Id = courseId
            var course = _courseRepository.GetCourseById(courseId);
            //check if null
            if (course == null) 
            {
                return NotFound();
            }
            //use the method in studentRepository
            var students = _studentRepository.GetStudentsInCourseId(courseId);
            //fill the viewmodel
            var coursesStudentsViewModel = new CoursesStudentsViewModel
            {
                PageTitle = $"Students in {course.Name}",
                Students = students.Select(s => new BaseViewModel
                {
                    Id = s.Id,
                    Value = $"{s.FirstName} {s.LastName}"
                })
            };
            //pass to the view
            return View(coursesStudentsViewModel);
        }
    }
}
