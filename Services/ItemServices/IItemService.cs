using TrainingForDatabase.Models;
using System.Collections.Generic;
using TrainingForDatabase.ItemVM;
using TrainingForDatabase.ViewModels.Item;

namespace TrainingForDatabase.services
{
    public interface IItemService
    {
        Task<ItemListVM> GetAllItems(string SearchValue, string SortColumn, string ColDir, int Skip, int PageSize, string lang = "");
        Task<bool> AddItem(itemVM item);
        Task<itemVM> GetItemById(int id);

        Task<bool> Update(itemVM newly);

        Task<bool> Delete(int id);

        Task<byte[]> ExportToExcel(string SearchValue, string SortColumn, string ColDir, int Skip, int PageSize, string lang = "");



    }
}
