using ShopApp.Models;

namespace ShopApp.Factories
{
    public static class UserFactory
    {
        public static User GetWithBalance(double balance)
        {
            return new User()
            {
                Balance = balance
            };
        }
    }
}