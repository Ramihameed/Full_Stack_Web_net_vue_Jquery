using System.ComponentModel.DataAnnotations;
using TrainingForDatabase.Models;

namespace TrainingForDatabase.ViewModels.Course
{
    public class CourseVM
    {


        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public string? Students { get; set; }

        // Navigation property
        public ICollection<TrainingForDatabase.Models.StudentCourses> StudentCourses { get; set; }
    }
}
