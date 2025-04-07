using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrainingForDatabase.Data;
using TrainingForDatabase.Models;
using TrainingForDatabase.Services.StudentCourseServices;
using TrainingForDatabase.ViewModels.Course;
using TrainingForDatabase.ViewModels.Student;
using TrainingForDatabase.ViewModels.StudentCourses;

namespace TrainingForDatabase.Controllers
{
    public class StudentCourseController : Controller
    {

        private readonly ApplicationDbContext _context;

        private readonly IStudentCourseService _student_course_service;

        public StudentCourseController(IStudentCourseService studentService, ApplicationDbContext context)
        {
            _student_course_service = studentService;

            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }


        // POST: StudentCourses/Create
        [HttpPost]

        public async Task<IActionResult> Create([FromBody] StudentCoursesVM model)
        {
            var res = await  _student_course_service.Create(model);

            if (res)
            {
                return Ok("Enrolled Successfully");

            }
            else
            {
                return BadRequest();
            }
        }
    }
}

