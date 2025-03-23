using TrainingForDatabase.Models;
using System.Collections.Generic;
using TrainingForDatabase.ItemVM;

namespace TrainingForDatabase.services
{
    public interface IItemService
    {
       Task<List<Item>> GetAllItems();
       Task<bool> AddItem(itemVM item );
       Task<itemVM> GetItemById(int id);

       Task<bool> Update(itemVM newly);

       Task<bool> Delete(int id);


    }
}
