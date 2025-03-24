using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TrainingForDatabase.Data;
using TrainingForDatabase.services;
using TrainingForDatabase.Services.DepartmentServices;

namespace TrainingForDatabase.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly IDepartmentService _department_service;

        public DepartmentController(IDepartmentService departmentService, ApplicationDbContext context)
        {
            _department_service = departmentService;

            _context = context;
        }



        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDepartments() 
        {

            var x = await _department_service.GetAllItems();

            if (x != null)
            {
                return Ok(x);
            }
            else
            {
                return BadRequest("err");
            }

        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _department_service.Delete(id);

            if (result)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

    }
}
