using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TrainingForDatabase.services;
using TrainingForDatabase.Services.DepartmentServices;

namespace TrainingForDatabase.Controllers
{
    public class DepartmentController : Controller
    {


        private readonly IDepartmentService _department_service;

        public DepartmentController(IDepartmentService departmentService)
        {
            _department_service = departmentService;
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
                return BadRequest("errp");
            }

        }
    }
}
