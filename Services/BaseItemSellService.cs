using System;
using ShopApp.Helpers;
using ShopApp.Interfaces;
using ShopApp.Models;

namespace ShopApp.Services
{
    public class BaseItemSellService : IItemSellService
    {
        public string SellItem(Shop shop, User user, string buyItem, int buyQuantity)
        {
            var forSale = shop.Items.Find(balance =>
                balance.Item.Name.Equals(buyItem, StringComparison.OrdinalIgnoreCase));

            if (forSale != null)
            {
                if (forSale.Quantity >= buyQuantity)
                {
                    var hasUserEnoughMoney = buyQuantity * forSale.Item.Price <= user.Balance;
                    if (!hasUserEnoughMoney)
                    {
                        return Message.NotEnoughMoney;
                    }

                    forSale.Quantity -= buyQuantity;
                    user.Balance -= forSale.Item.Price * buyQuantity;
                    return Message.ItemSold;
                }

                if (forSale.Quantity == 0)
                {
                    return Message.ItemSoldOut;
                }

                return Message.WantedQuantityIsTooHigh;
            }

            return Message.ItemNotFound;
        }
    }
}