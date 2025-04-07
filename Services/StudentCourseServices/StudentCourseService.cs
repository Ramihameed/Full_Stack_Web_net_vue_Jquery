using Microsoft.EntityFrameworkCore;
using TrainingForDatabase.Data;
using TrainingForDatabase.Models;
using TrainingForDatabase.ViewModels.Course;
using TrainingForDatabase.ViewModels.Student;
using TrainingForDatabase.ViewModels.StudentCourses;

namespace TrainingForDatabase.Services.StudentCourseServices
{
    public class StudentCourseService : IStudentCourseService
    {

        private readonly ApplicationDbContext _context;

        public StudentCourseService(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<bool> Create(StudentCoursesVM model)
        {
            try
            {
                // Create a new instance of StudentCourses based on the incoming model
                var studentCourse = new StudentCourses
                {
                    StudentId = model.StudentId,
                    CourseId = model.CourseId
                };

                // Add the new student-course relationship to the DbContext
                await _context.StudentCourses.AddAsync(studentCourse);

                // Save changes to the database
                await _context.SaveChangesAsync();

                // Return true if changes were successfully saved (i.e., the insert was successful)
                return true;
            }
            catch (Exception ex)
            {
                // Log the error here if needed
                Console.WriteLine($"Error: {ex.Message}");

                // Return false if something went wrong
                return false;
            }
        }

    }
}
