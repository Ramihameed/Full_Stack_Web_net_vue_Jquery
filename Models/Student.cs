using System.ComponentModel.DataAnnotations;

namespace TrainingForDatabase.Models
{
    public class Student
    {

        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }

        public ICollection<StudentCourses> StudentCourses { get; set; }
    }
}
