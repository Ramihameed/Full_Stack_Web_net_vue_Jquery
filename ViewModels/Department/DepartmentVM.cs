using System.ComponentModel.DataAnnotations;
using TrainingForDatabase.ItemVM;
using TrainingForDatabase.Models;
namespace TrainingForDatabase.ViewModels.Department
{
    public class DepartmentVM
    {   
            public int Id { get; set; }


            public string name { get; set; }

            public ICollection<itemVM> items { get; set; }

            public Media Media { get; set; }


    }
}
