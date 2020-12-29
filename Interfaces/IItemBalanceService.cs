using ShopApp.Models;

namespace ShopApp.Interfaces
{
    public interface IItemBalanceService
    {
        string AddItem(Shop shop, string addItem, int addQuantity);
    }
}