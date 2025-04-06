using System.ComponentModel.DataAnnotations;

namespace TrainingForDatabase.Models
{
    public class Media
    {
        [Key]
        public int Id { get; set; }

        public string FilePath { get; set; }

        // Foreign Key to Department
        public int DepartmentId { get; set; }

        // Navigation property to Department
        public Department Department { get; set; }
    }

}
