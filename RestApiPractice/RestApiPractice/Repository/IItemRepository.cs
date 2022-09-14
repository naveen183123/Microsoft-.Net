using RestApiPractice.Models;
namespace RestApiPractice.Repository
{
    public interface IItemRepository
    {
        IEnumerable<items> GetItems();
        items GetItems(Guid id);
        void CreateItem(items item);
        void UpdateItem(items item);
        void DeleteItem(Guid id);
    }
}