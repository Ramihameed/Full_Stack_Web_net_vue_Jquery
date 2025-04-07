using TrainingForDatabase.ViewModels.Course;
using TrainingForDatabase.ViewModels.Student;

namespace TrainingForDatabase.Services.CourseServices
{
    public interface ICourseService
    {

        Task<List<CourseVM>> GetAllCourses();

        Task<List<StudentVM>> GetStudentsInCourse(int CourseId);

        public Task<List<CourseVM>> updateCoursesWithStudents();



    }
}
