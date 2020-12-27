using System;
using ShopApp.Models;
using ShopApp.Models.Items;

namespace ShopApp.Factories
{
    public static class ItemFactory
    {
        public static Item Get(string itemName)
        {
            switch (itemName.ToLower())
            {
                case "book":
                    return new Book()
                    {
                        Quantity = 12,
                        Price = 19.90
                    };
                case "candy":
                    return new Candy()
                    {
                        Quantity = 120,
                        Price = 4.90
                    };
                case "cup":
                    return new Cup()
                    {
                        Quantity = 2,
                        Price = 9.90
                    };
                default:
                    throw new NotSupportedException();
            }
        }
    }
}