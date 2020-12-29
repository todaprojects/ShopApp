using ShopApp.Helpers;
using ShopApp.Models;

namespace ShopApp.Services
{
    public class BaseUserBalanceService : IUserBalanceService
    {
        public string AddBalance(User user, decimal moneyAmount)
        {
            user.Balance += moneyAmount;
            return Message.MoneyAdded;
        }
    }
}