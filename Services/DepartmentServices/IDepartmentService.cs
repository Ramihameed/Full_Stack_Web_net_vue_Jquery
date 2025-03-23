using TrainingForDatabase.Models;

namespace TrainingForDatabase.Services.DepartmentServices
{
    public interface IDepartmentService
    {
        Task<List<Department>> GetAllItems();

    }
}
