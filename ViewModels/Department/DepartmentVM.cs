using System.ComponentModel.DataAnnotations;

namespace TrainingForDatabase.ViewModels.Department
{
    public class DepartmentVM
    {
        [Required]
        public string dep_name { get; set; }
    }
}
