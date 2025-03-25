using TrainingForDatabase.Data;
using TrainingForDatabase.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TrainingForDatabase.ItemVM;

namespace TrainingForDatabase.services
{
    public class ItemService : IItemService
    {
        private readonly ApplicationDbContext _context;

        public ItemService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Item>> GetAllItems()
        {
            try
            {
                await _context.Items.ToListAsync();

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error: {ex.Message}");

            }
            return await _context.Items.ToListAsync();

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
                Departmentname = item.Departmentname
            };
            return newItem;

        }

        public async Task<bool> Update(itemVM model)
        {
            try
            {

                var data = await _context.Items.FindAsync(model.Id);

                data.Departmentname = model.Departmentname;
                data.name = model.name;
                data.description = model.description;
                data.price = model.price;


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


