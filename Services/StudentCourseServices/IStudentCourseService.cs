using TrainingForDatabase.Models;
using TrainingForDatabase.ViewModels.StudentCourses;

namespace TrainingForDatabase.Services.StudentCourseServices
{
    public interface IStudentCourseService
    {

        public Task<bool> Create(StudentCoursesVM model);
    }
}
