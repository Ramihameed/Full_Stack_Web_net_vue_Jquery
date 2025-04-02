using Microsoft.AspNetCore.Mvc;
using TrainingForDatabase.ItemVM;
using TrainingForDatabase.Models;
using TrainingForDatabase.ViewModels.Department;

namespace TrainingForDatabase.Services.DepartmentServices
{
    public interface IDepartmentService
    {
        Task<List<Department>> GetAllItems();

        Task<bool> Delete(int id);

        Task<Department> GetItemById(int id);

        Task<bool> AddItem(DepartmentVM model);


        Task<bool> Update(DepartmentVM model);

    }
}
