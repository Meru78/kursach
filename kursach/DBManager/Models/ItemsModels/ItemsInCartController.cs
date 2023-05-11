using kursach.DBManager.Models.ItemModels;

namespace kursach.DBManager.Models.ItemsModels
{
    public class ItemsInCartController
    {
        private List<Item>? ItemsInCart { get; set; }
        public List<Item> GetItemsFromCart() { return ItemsInCart; }
        public void ClearCart()
        {
            ItemsInCart = null;
        }
        public List<Item> DestroyItemInCart(Item item)
        {
            ItemsInCart.Remove(item);
            return ItemsInCart;
        }
        public List<Item> AddItemsToCart(Item item)
        {
            if (ItemsInCart == null)
            {
                ItemsInCart = new List<Item>() { item };
            }
            else
            {
                var check = ItemsInCart.Where(row => row.ItemId == item.ItemId).ToList();
                if (check.Count == 0) ItemsInCart.Add(item);
            }

            return ItemsInCart;
        }
    }
}
