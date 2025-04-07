using Microsoft.EntityFrameworkCore;
using TrainingForDatabase.Data;
using TrainingForDatabase.Models;
using TrainingForDatabase.ViewModels.MediaVM;
using TrainingForDatabase.ViewModels.Student;

namespace TrainingForDatabase.Services.StudentServices
{
    public class StudentService : IStudentService
    {


        private readonly ApplicationDbContext _context;

        public StudentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<StudentVM>> GetAllStudents()
        {
            var studentList = await _context.Students
                                            .Include(s => s.StudentCourses)
                                            .ThenInclude(x => x.Course)
                                            .ToListAsync();

            var studentViewModel = studentList.Select(student => new StudentVM
            {
                StudentId = student.StudentId,
                Name = student.Name,
                Course = string.Join(", ", student.StudentCourses.Select(x => x.Course.CourseName)) 
            }).ToList();

            return studentViewModel;
        }



    }
}
