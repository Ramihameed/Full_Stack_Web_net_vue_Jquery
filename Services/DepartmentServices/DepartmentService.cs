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
    }
}
