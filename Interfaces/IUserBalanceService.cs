using ShopApp.Models;

namespace ShopApp.Interfaces
{
    public interface IUserBalanceService
    {
        string AddBalance(User user, decimal moneyAmount);
    }
}