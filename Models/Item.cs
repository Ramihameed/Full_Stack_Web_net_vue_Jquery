using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingForDatabase.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string description { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Price must be a positive number.")]
        public int price { get; set; }

        public int? DepartmentId { get; set; }

        public Department? Department { get; set; }
    }
}
