using TrainingForDatabase.Data;
using TrainingForDatabase.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TrainingForDatabase.ItemVM;
using TrainingForDatabase.ViewModels.Item;
using System.Linq.Dynamic.Core;


namespace TrainingForDatabase.services
{
    public class ItemService : IItemService
    {
        private readonly ApplicationDbContext _context;


        public ItemService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ItemListVM> GetAllItems(string SearchValue, string SortColumn, string ColDir, int Skip, int PageSize, string lang = "")
        {
            try
            {
                int recordsTotal = await _context.Items.CountAsync();

                var models = _context.Items.Include(i => i.Department)
                    .AsEnumerable<Models.Item>()
                    .Select(i => new itemVM
                    {
                        name = i.name,
                        description = i.description != null ? i.description : "",
                        price = i.price                        
                    }).AsQueryable().OrderBy(SortColumn + " " + ColDir).Skip(Skip).Take(PageSize).ToList();


                var Data = new ItemListVM
                {
                    itemList = models,
                    RecordsTotal = recordsTotal,
                };
                return Data;

            }
            catch (Exception exc)
            {

                var Data = new ItemListVM
                {
                    itemList = new List<itemVM>(),
                    RecordsTotal = 0,
                };
                return Data;
            }
        }


        public async Task<bool> AddItem(itemVM item)
        {
            try
            {
                var newItem = new Item
                {
                    name = item.name,
                    description = item.description,
                    price = item.price,
                    Id = item.Id,

                };


                await _context.Items.AddAsync(newItem);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        public async Task<itemVM> GetItemById(int id)
        {
            var item = await _context.Items.FindAsync(id);

            var newItem = new itemVM
            {
                Id = item.Id,
                name = item.name,
                description = item.description,
                price = item.price,
                DepartmentId = item.DepartmentId
            };
            return newItem;

        }

        public async Task<bool> Update(itemVM model)
        {
            try
            {

                var data = await _context.Items.FindAsync(model.Id);

                data.name = model.name;
                data.description = model.description;
                data.price = model.price;
                data.Departmentname = model.Departmentname;


                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }


        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                var data = await _context.Items.FindAsync(id);

                _context.Items.Remove(data);
                await _context.SaveChangesAsync();

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");

                return false;
            }


        }
    }






}


