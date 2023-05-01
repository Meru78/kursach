using kursach.DBManager.Models.ItemModels;

namespace kursach.DBManager.Models.ItemsModels
{
    public class ItemsController
    {
        public ItemsController(DBManager context)
        {
            _context = context;
        }

        DBManager _context;

        public void CreateItemsFromArray(Item[] items)
        {
            _context.Items.AddRange(items);
            _context.SaveChanges();
        }

        public Task<Item[]> GetItemsBySupplyId(int id)
        {
            var items = _context.Items.Where(row => row.SupplyID == id).ToArray();

            return Task.FromResult(items);
        }

        public void DeleteItemsFromArray(Item[] items)
        {
            _context.Items.RemoveRange(items);
            _context.SaveChanges();
        }
        public Task<Item[]> GetItems()
        {
            var items = _context.Items.ToArray();

            return Task.FromResult(items);
        }
    }
}
