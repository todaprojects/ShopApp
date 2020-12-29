using ShopApp.Models;

namespace ShopApp.Services
{
    public interface IItemSellService
    {
        string SellItem(Shop shop, User user, string buyItem, int buyQuantity);
    }
}