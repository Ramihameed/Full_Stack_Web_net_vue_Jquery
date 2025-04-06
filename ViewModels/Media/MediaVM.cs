using System.ComponentModel.DataAnnotations;
using TrainingForDatabase.Models;
using TrainingForDatabase.ViewModels.Department;

namespace TrainingForDatabase.ViewModels.MediaVM
{
    public class MediaVM
    {
        
        public int Id { get; set; }

        public IFormFile File { get; set; }
        public string? FilePath { get; set; }

        // Foreign Key to Department
        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; }

        // Navigation property to Department
        public TrainingForDatabase.Models.Department Department { get; set; }
    }

}

