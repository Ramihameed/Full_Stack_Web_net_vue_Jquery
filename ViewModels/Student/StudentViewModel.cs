using TrainingForDatabase.Models;

namespace TrainingForDatabase.ViewModels.Student
{
    public class StudentViewModel
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public string Course { get; set; }
        public ICollection<StudentCourses> StudentCourses { get; set; }

    }
}
