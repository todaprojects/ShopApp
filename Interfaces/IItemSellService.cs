using ShopApp.Models;

namespace ShopApp.Interfaces
{
    public interface IItemSellService
    {
        string SellItem(Shop shop, User user, string buyItem, int buyQuantity);
    }
}