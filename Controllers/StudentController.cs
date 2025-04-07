using Microsoft.AspNetCore.Mvc;
using TrainingForDatabase.Data;
using TrainingForDatabase.Services.StudentServices;

namespace TrainingForDatabase.Controllers
{
    public class StudentController : Controller
    {


        private readonly ApplicationDbContext _context;

        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService, ApplicationDbContext context)
        {
            _studentService = studentService;

            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {

            var x = await _studentService.GetAllStudents();

            if (x != null)
            {
                return Ok(x);
            }
            else
            {
                return BadRequest("err");
            }

        }

    }
}
