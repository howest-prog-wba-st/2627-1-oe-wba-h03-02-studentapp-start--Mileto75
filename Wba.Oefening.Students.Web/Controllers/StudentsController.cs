using Microsoft.AspNetCore.Mvc;
using Wba.Oefening.Students.Core.Repositories;
using Wba.Oefening.Students.Web.ViewModels;

namespace Wba.Oefening.Students.Web.Controllers
{
    public class StudentsController : Controller
    {
        private readonly StudentRepository _studentRepository = new();

        public IActionResult Index()
        {
            //show a list of students
            //get the students
            var students = _studentRepository.Students;
            //put in viewmodel
            var studentsIndexViewModel
                = new StudentsIndexViewModel
                {
                    PageTitle = "Our students",
                    Students = students.Select(s => new BaseViewModel
                    {
                        Id = s.Id,
                        Value = $"{s.FirstName} {s.LastName}"
                    })
                };
            //pass to the view
            return View(studentsIndexViewModel);
        }
    }
}
