using Microsoft.EntityFrameworkCore;
using TrainingForDatabase.Data;
using TrainingForDatabase.Models;
using TrainingForDatabase.services;

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
    }
} /*
        public async Task<Department> CreateDepartmentAsync(Department department)
        {
            if (department == null)
            {
                throw new ArgumentNullException(nameof(department), "Department cannot be null.");
            }

            await _context.Departments.AddAsync(department);
            await _context.SaveChangesAsync();

            return department;  // Return the created department
        }

        public async Task<List<Department>> GetAllDepartmentsAsync()
        {
            return await _context.Departments.ToListAsync();
        }

        #region Read (Get a single department by ID)
        public async Task<Department> GetDepartmentByIdAsync(int departmentId)
        {
            return await _context.Departments
                .FirstOrDefaultAsync(d => d.Id == departmentId);
        }
        #endregion

        public async Task<bool> UpdateDepartmentAsync(int departmentId, Department updatedDepartment)
        {
            if (updatedDepartment == null)
            {
                throw new ArgumentNullException(nameof(updatedDepartment), "Updated department cannot be null.");
            }

            var department = await _context.Departments
                .FirstOrDefaultAsync(d => d.Id == departmentId);

            if (department == null)
            {
                return false;  
            }

            department.name = updatedDepartment.Name;
            department.Description = updatedDepartment.Description;

            _context.Departments.Update(department);
            await _context.SaveChangesAsync();

            return true;
        }
        


        public async Task<bool> DeleteDepartmentAsync(int departmentId)
        {
            var department = await _context.Departments
                .FirstOrDefaultAsync(d => d.Id == departmentId);

            if (department == null)
            {
                return false;  // Department not found
            }

            _context.Departments.Remove(department);
            await _context.SaveChangesAsync();

            return true;
        }

}
}
*/