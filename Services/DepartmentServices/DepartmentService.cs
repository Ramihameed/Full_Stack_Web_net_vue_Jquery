using Microsoft.EntityFrameworkCore;
using TrainingForDatabase.Data;
using TrainingForDatabase.ItemVM;
using TrainingForDatabase.Models;
using TrainingForDatabase.services;
using TrainingForDatabase.ViewModels.Department;

namespace TrainingForDatabase.Services.DepartmentServices
{
    public class DepartmentService : IDepartmentService
    {

        private readonly ApplicationDbContext _context;

        public DepartmentService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Department>> GetAllItems()
        {
            return await _context.Departments.ToListAsync();
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                var data = await _context.Departments.FindAsync(id);

                _context.Departments.Remove(data);
                await _context.SaveChangesAsync();

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");

                return false;
            }


        }


        public async Task<bool> AddItem(DepartmentVM model)
        {
            try
            {

                var newDepartment = new Department
                {
                    name = model.name
                };
               


                await _context.Departments.AddAsync(newDepartment);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

         public async Task<Department> GetItemById(int id)
         {
             var item = await _context.Departments.FindAsync(id);

            
            return item;

        }

        public async Task<bool> Update(DepartmentVM model)
        {
            try
            {

                var data = await _context.Departments.FindAsync(model.Id);

                data.name = model.name;
                


                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }


        }


    }
} 