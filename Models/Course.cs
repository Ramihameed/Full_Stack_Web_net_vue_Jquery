using System.ComponentModel.DataAnnotations;

namespace TrainingForDatabase.Models
{
    public class Course
    {

        [Key]

        public int CourseId { get; set; }
        public string CourseName { get; set; }

        // Navigation property
        public ICollection<StudentCourses> StudentCourses { get; set; }
    }
}
