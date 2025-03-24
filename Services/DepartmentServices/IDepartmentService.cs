using Microsoft.AspNetCore.Mvc;
using TrainingForDatabase.Models;

namespace TrainingForDatabase.Services.DepartmentServices
{
    public interface IDepartmentService
    {
        Task<List<Department>> GetAllItems();

        Task<bool> Delete(int id);


    }
}
