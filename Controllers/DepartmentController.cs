using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;
using TrainingForDatabase.Data;
using TrainingForDatabase.ItemVM;
using TrainingForDatabase.Models;
using TrainingForDatabase.services;
using TrainingForDatabase.Services.DepartmentServices;
using TrainingForDatabase.ViewModels.Department;

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

        [HttpGet]
        public async Task<IActionResult> GetItemById(int id)
        {
            var result = await _department_service.GetItemById(id);

            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            } 
        } 

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            return View(id);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromBody] DepartmentVM item)
        {

            var res = await _department_service.Update(item);
            if (res)
            {

                return Ok("success");
            }
            else
            {
                return BadRequest();
            }
        }

        public async Task<IActionResult> AddItemPage()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddItem([FromBody] DepartmentVM model)
        {

            var x = await _department_service.AddItem(model);

            if (x)
            {
                return Ok("success");
            }
            else
            {
                return BadRequest();
            }

        }



    }
}
