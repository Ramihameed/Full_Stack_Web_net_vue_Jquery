using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrainingForDatabase.ItemVM;
using TrainingForDatabase.services;

namespace TrainingForDatabase.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemRepository)
        {
            _itemService = itemRepository;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Editt(int id)
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            return View(id);
        }



        [HttpPost]
        public async Task<IActionResult> GetItems()
        {


            try
            {



                var draw = Request.Form["draw"].FirstOrDefault();

                // Skip number of Rows count  
                var start = Request.Form["start"].FirstOrDefault();

                // Paging Length 10,20  
                var length = Request.Form["length"].FirstOrDefault();

                // Sort Column Name  
                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();


                // Sort Column Direction (asc, desc)  
                var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
                var colDir = "";
                if (sortColumnDirection == "asc")
                {
                    colDir = "ascending";
                }
                else
                {
                    colDir = "descending";
                }
                if (string.IsNullOrEmpty(sortColumn))
                {
                    sortColumn = "id";
                }
                // Search Value from (Search box)  
                int pageSize = length != null ? Convert.ToInt32(length) : 0;

                //var culture = (await _workContext.GetCurrentUser()).Culture;

                int skip = start != null ? Convert.ToInt32(start) : 0;



                var searchValue = Request.Form["search[value]"].FirstOrDefault();





                var data = await _itemService.GetAllItems(searchValue, sortColumn, colDir, skip, pageSize);



                return Json(new { draw = draw, RecordsTotal = data.RecordsTotal, data = data.itemList });


            }
            catch (Exception exc)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exc.Message);
            }
        }






        [HttpGet]
        public async Task<IActionResult> AddItemPage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddItem([FromBody] itemVM item)
        {

            var x = await _itemService.AddItem(item);

            if (x)
            {
                return Ok("success");
            }
            else
            {
                return BadRequest();
            }

        }



        [HttpPost]
        public async Task<IActionResult> Update([FromBody] itemVM item)
        {

            var res = await _itemService.Update(item);
            if (res)
            {

                return Ok("success");
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetItemById(int id)
        {
            var result = await _itemService.GetItemById(id);

            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _itemService.Delete(id);

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
        public async Task<IActionResult> Deletee()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> ExportToExcel(string SearchValue, string SortColumn, string ColDir, int Skip, int PageSize)
        {
            try
            {
                byte[] fileContents = await _itemService.ExportToExcel(SearchValue, SortColumn, ColDir, Skip, PageSize);
                return File(fileContents, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "items.xlsx");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
