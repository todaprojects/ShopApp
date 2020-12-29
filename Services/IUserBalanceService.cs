using ShopApp.Models;

namespace ShopApp.Services
{
    public interface IUserBalanceService
    {
        string AddBalance(User user, decimal moneyAmount);
    }
}