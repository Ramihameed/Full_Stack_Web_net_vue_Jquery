using System.ComponentModel.DataAnnotations;

namespace TrainingForDatabase.Models
{
    public class StudentCourses
    {

        //[Key]
        //public int StudentCoursesId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
