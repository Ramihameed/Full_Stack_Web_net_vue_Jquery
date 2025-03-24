using System.ComponentModel.DataAnnotations;
using TrainingForDatabase.Models;

namespace TrainingForDatabase.ItemVM
{
        public class itemVM
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


