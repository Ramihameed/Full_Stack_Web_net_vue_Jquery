using System.ComponentModel.DataAnnotations;

namespace TrainingForDatabase.ItemVM
{
    public class itemVM
    {
        public int Id { get; set; }
        [Required]
        public string name { get; set; }

        [Required]
        public string description { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Price must be a positive number.")]
        public int price { get; set; }
    }
}
