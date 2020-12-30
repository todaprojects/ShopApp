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
            var itemForSale = shop.Items.Find(item =>
                item.Name.Equals(buyItem, StringComparison.OrdinalIgnoreCase));

            if (itemForSale != null)
            {
                if (itemForSale.Quantity >= buyQuantity)
                {
                    var hasUserEnoughMoney = buyQuantity * itemForSale.Price <= user.Balance;
                    if (!hasUserEnoughMoney)
                    {
                        return Message.NotEnoughMoney;
                    }

                    itemForSale.Quantity -= buyQuantity;
                    user.Balance -= itemForSale.Price * buyQuantity;
                    return Message.ItemSold;
                }

                if (itemForSale.Quantity == 0)
                {
                    return Message.ItemSoldOut;
                }

                return Message.WantedQuantityIsTooHigh;
            }

            return Message.ItemNotFound;
        }
    }
}