using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace TrainingForDatabase.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string dep_name { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}
