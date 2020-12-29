using ShopApp.Services;

namespace ShopApp.Models
{
    public class User
    {
        public decimal Balance { get; set; }
        
        private IUserBalanceService UserBalanceService { get; set; }

        public User()
        {
            UserBalanceService = ServiceFactory.GetUserBalanceService();
        }

        public string AddBalance(decimal moneyAmount)
        {
            return UserBalanceService.AddBalance(this, moneyAmount);
        }
    }
}