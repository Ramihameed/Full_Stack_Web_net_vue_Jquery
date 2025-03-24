using Microsoft.AspNetCore.Mvc;
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


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            return View(id);
        }



        [HttpGet]
        public async Task<IActionResult> GetItems()
        {
            var items = await _itemService.GetAllItems();
            if (items != null)
            {
                return Ok(items);
            }
            else
            {
                return BadRequest();
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
    }
}
