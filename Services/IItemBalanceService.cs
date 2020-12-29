using ShopApp.Models;

namespace ShopApp.Services
{
    public interface IItemBalanceService
    {
        string AddItem(Shop shop, string addItem, int addQuantity);
    }
}