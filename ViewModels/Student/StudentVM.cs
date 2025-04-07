using TrainingForDatabase.Models;

namespace TrainingForDatabase.ViewModels.Student
{
    public class StudentVM
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public string Course { get; set; }
        public ICollection<TrainingForDatabase.Models.StudentCourses> StudentCourses { get; set; }

    }
}
