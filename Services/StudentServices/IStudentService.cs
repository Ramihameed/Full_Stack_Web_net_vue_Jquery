using TrainingForDatabase.Models;
using TrainingForDatabase.ViewModels.Student;

namespace TrainingForDatabase.Services.StudentServices
{
    public interface IStudentService
    {

        Task<List<StudentViewModel>> GetAllStudents();

    }
}
