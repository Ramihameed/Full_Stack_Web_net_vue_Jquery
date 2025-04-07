using Microsoft.EntityFrameworkCore;
using TrainingForDatabase.Data;
using TrainingForDatabase.Models;
using TrainingForDatabase.ViewModels.Course;
using TrainingForDatabase.ViewModels.Student;

namespace TrainingForDatabase.Services.CourseServices
{
    public class CourseService : ICourseService
    {
        private readonly ApplicationDbContext _context;

        public CourseService(ApplicationDbContext context)
        {
            _context = context;
        }



        public async Task<List<CourseVM>> GetAllCourses()
        {
            var studentList = await _context.Courses
                                            .Include(c => c.StudentCourses)
                                            .ThenInclude(x => x.Student)
                                            .ToListAsync();

            var studentViewModel = studentList.Select(student => new CourseVM
            {
                CourseId = student.CourseId,
                CourseName = student.CourseName,
                Students = string.Join(", ", student.StudentCourses.Select(x => x.Student.Name))
            }).ToList();

            return studentViewModel;
        }

        public async Task<List<StudentVM>> GetStudentsInCourse(int courseId)
        {


            var studentsInCourse = await _context.StudentCourses
        .Where(sc => sc.CourseId == courseId)
        .Include(sc => sc.Student).Include(sc => sc.Course)
        .Select(sc => new StudentVM
        {
            StudentId = sc.Student.StudentId,
            Name = sc.Student.Name,
            Course = sc.Course.CourseName

            // Add other properties of the StudentVM as needed
        })
        .ToListAsync(); // Execute asynchronously

            return studentsInCourse;
        }

        public async Task<List<CourseVM>> updateCoursesWithStudents()
        {


            var coursesWithStudents = await _context.Courses
    .Include(c => c.StudentCourses)        
    .ThenInclude(sc => sc.Student)       
    .Where(c => c.StudentCourses.Any())    
    .ToListAsync();



            var Result = coursesWithStudents.Select(c => new CourseVM
            {
                CourseId = c.CourseId,
                CourseName = c.CourseName,

                Students = string.Join(", ", c.StudentCourses.Select(x => x.Student.Name) )
            }).ToList();


            return Result;
        }

    }
}
