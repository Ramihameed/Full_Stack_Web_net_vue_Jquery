using System.ComponentModel.DataAnnotations;
using TrainingForDatabase.Models;

namespace TrainingForDatabase.ViewModels.Course
{
    public class CourseViewModel
    {


        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public string? Students { get; set; }

        // Navigation property
        public ICollection<StudentCourses> StudentCourses { get; set; }
    }
}
