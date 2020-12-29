using System;
using ShopApp.Helpers;
using ShopApp.Interfaces;
using ShopApp.Models;

namespace ShopApp.Services
{
    public class BaseItemBalanceService : IItemBalanceService
    {
        public string AddItem(Shop shop, string addItem, int addQuantity)
        {
            var toAdd = shop.Items.Find(balance =>
                balance.Item.Name.Equals(addItem, StringComparison.OrdinalIgnoreCase));

            if (toAdd != null)
            {
                toAdd.Quantity += addQuantity;
                return Message.ItemAdded;
            }

            return Message.ItemNotAdded;
        }
    }
}