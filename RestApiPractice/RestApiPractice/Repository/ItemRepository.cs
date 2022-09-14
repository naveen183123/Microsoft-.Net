using RestApiPractice.Models;
namespace RestApiPractice.Repository
{
    public class ItemRepository : IItemRepository
    {
        private readonly List<items> ii = new()
        {
            new items { id = Guid.NewGuid(), Name = "spochi", Price = 11, ManufacDate = DateTimeOffset.UtcNow },
            new items { id = Guid.NewGuid(), Name = "Moragow", Price = 21, ManufacDate = DateTimeOffset.UtcNow },
            new items { id = Guid.NewGuid(), Name = "Daikan", Price = 41, ManufacDate = DateTimeOffset.UtcNow },
            new items { id = Guid.NewGuid(), Name = "Delicata Squash", Price = 12, ManufacDate = DateTimeOffset.UtcNow },
            new items { id = Guid.NewGuid(), Name = "SunChokes", Price = 86, ManufacDate = DateTimeOffset.UtcNow },

        };

        public void CreateItem(items item)
        {
            ii.Add(item);
        }

        public void DeleteItem(Guid id)
        {
            var i = ii.FindIndex(Eitem => Eitem.id == id);
            ii.RemoveAt(i);
        }

        public IEnumerable<items> GetItems()
        {
            return ii;
        }
        public items GetItems(Guid id)
        {
            return ii.Where(item => item.id == id).SingleOrDefault();
        }

        public void UpdateItem(items item)
        {
            var index = ii.FindIndex(Eitem => Eitem.id == item.id);
            ii[index] = item;
        }
    }
}
