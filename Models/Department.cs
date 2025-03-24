using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace TrainingForDatabase.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        
        public string name { get; set; }

        public ICollection<Item>? items { get; set; }
    }
}
