using Microsoft.EntityFrameworkCore;
using TrainingForDatabase.Data;
using TrainingForDatabase.ViewModels.Course;

namespace TrainingForDatabase.Services.CourseServices
{
    public class CourseService : ICourseService
    {
        private readonly ApplicationDbContext _context;

        public CourseService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<CourseViewModel>> GetAllCourses()
        {
            var studentList = await _context.Courses
                                            .Include(c => c.StudentCourses)
                                            .ThenInclude(x => x.Student)
                                            .ToListAsync();

            var studentViewModel = studentList.Select(student => new CourseViewModel
            {
                CourseId = student.CourseId,
                CourseName = student.CourseName,
                Students = string.Join(", ", student.StudentCourses.Select(x => x.Student.Name))
            }).ToList();

            return studentViewModel;
        }
    }
}
