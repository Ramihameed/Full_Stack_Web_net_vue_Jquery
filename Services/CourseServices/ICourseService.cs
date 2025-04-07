using TrainingForDatabase.ViewModels.Course;

namespace TrainingForDatabase.Services.CourseServices
{
    public interface ICourseService
    {

        Task<List<CourseViewModel>> GetAllCourses();

    }
}
