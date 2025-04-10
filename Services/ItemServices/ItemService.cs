using TrainingForDatabase.Data;
using TrainingForDatabase.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TrainingForDatabase.ItemVM;
using TrainingForDatabase.ViewModels.Item;
using System.Linq.Dynamic.Core;
using OfficeOpenXml;
using System.IO;
using System.Linq;
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
                int recordsTotal = await _context.Items.Where(x => !string.IsNullOrEmpty(SearchValue) ? x.name.Trim().ToLower().Contains(SearchValue.Trim().ToLower()) : true).CountAsync();

                var models = _context.Items.Include(i => i.Department)
                    .AsEnumerable<Models.Item>()
                    .Where(x => !string.IsNullOrEmpty(SearchValue) ? x.name.Trim().ToLower().Contains(SearchValue.Trim().ToLower()) : true)

                    .Select(i => new itemVM
                    {
                        Id = i.Id,
                        name = i.name,
                        description = i.description != null ? i.description : "",
                        Departmentname = i.Department.name,
                        price = i.price //issue
                        //DepartmentId = i.DepartmentId,
                        //Department = i.Department,
                        //Departmentname = i.Department.name.ToString()
                        //Department = i.Department,
                        //Departmentname = i.Department.name != null ? i.Department.name : "h"
                    }).AsQueryable().OrderBy(SortColumn + " " + ColDir).Skip(Skip).Take(PageSize).ToList();

                // issue
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
                    DepartmentId = item.DepartmentId

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
                //Departmentname = item.Department.name
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

        public async Task<byte[]> ExportToExcel(string SearchValue, string SortColumn, string ColDir, int Skip, int PageSize, string lang = "")
        {
            var items = await _context.Items.Include(i => i.Department)
                .Where(x => !string.IsNullOrEmpty(SearchValue) ? x.name.Trim().ToLower().Contains(SearchValue.Trim().ToLower()) : true)
                .Select(i => new
                {
                    i.Id,
                    i.name,
                    i.description,
                    i.price,
                    DepartmentName = i.Department.name
                })
                .ToListAsync();

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Items");

                // Add header row
                worksheet.Cells["A1"].Value = "Id";
                worksheet.Cells["B1"].Value = "Name";
                worksheet.Cells["C1"].Value = "Description";
                worksheet.Cells["D1"].Value = "Price";
                worksheet.Cells["E1"].Value = "Department Name";

                // Add data rows
                for (int i = 0; i < items.Count; i++)
                {
                    worksheet.Cells[i + 2, 1].Value = items[i].Id;
                    worksheet.Cells[i + 2, 2].Value = items[i].name;
                    worksheet.Cells[i + 2, 3].Value = items[i].description;
                    worksheet.Cells[i + 2, 4].Value = items[i].price;
                    worksheet.Cells[i + 2, 5].Value = items[i].DepartmentName;
                }

                return package.GetAsByteArray(); // Return the Excel file as byte array
            }
        }






    }
}


