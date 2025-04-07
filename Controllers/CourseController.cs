using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrainingForDatabase.Data;
using TrainingForDatabase.Services.CourseServices;
using TrainingForDatabase.Services.StudentServices;
using TrainingForDatabase.ViewModels.Course;

namespace TrainingForDatabase.Controllers
{
    public class CourseController : Controller
    {

        private readonly ApplicationDbContext _context;

        private readonly ICourseService _course_service;

        public CourseController(ICourseService studentService, ApplicationDbContext context)
        {
            _course_service = studentService;

            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCourses()
        {

            var x = await _course_service.GetAllCourses();

            if (x != null)
            {
                return Ok(x);
            }
            else
            {
                return BadRequest("err");
            }

        }

        [HttpGet]
        public async Task<IActionResult> GetStudentsInCourse(int id)
        {

            var x = await _course_service.GetStudentsInCourse( id);

            if (x != null)
            {
                return Ok(x);
            }
            else
            {
                return BadRequest("err");
            }

        }

        [HttpGet] 
        public async Task<IActionResult> updateCoursesWithStudents()
        {


            var ListOfCoursesWithStudents =  await _course_service.updateCoursesWithStudents();

            if (ListOfCoursesWithStudents != null)
            {
                return Ok(ListOfCoursesWithStudents);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
