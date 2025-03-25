using Microsoft.AspNetCore.Mvc;
using TrainingForDatabase.ItemVM;
using TrainingForDatabase.Models;

namespace TrainingForDatabase.Services.DepartmentServices
{
    public interface IDepartmentService
    {
        Task<List<Department>> GetAllItems();

        Task<bool> Delete(int id);

        Task<Department> GetItemById(int id);

        Task<bool> AddItem(Department item);


        Task<bool> Update(Department newly);

    }
}
