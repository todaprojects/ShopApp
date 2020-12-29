namespace ShopApp.Models
{
    public class ModelFactory
    {
        public static Shop GetShop()
        {
            return new Shop();
        }
        
        public static User GetUser()
        {
            return new User()
            {
                Balance = 100
            };
        }
        
        public static ItemBalance GetItem(string name, decimal price)
        {
            return new ItemBalance()
            {
                Item = MakeItem(name, price),
                Quantity = 10
            };
        }

        private static Item MakeItem(string name, decimal price)
        {
            return new Item()
            {
                Name = name,
                Price = price
            };
        }
    }
}