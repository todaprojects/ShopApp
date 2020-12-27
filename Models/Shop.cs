using System;
using System.Collections.Generic;
using System.Text;
using ShopApp.Views;

namespace ShopApp.Models
{
    public class Shop
    {
        public List<Item> Items { get; set; }
        public User User { get; set; }

        public Shop()
        {
            Items = new List<Item>();
        }

        public string GetItemList()
        {
            StringBuilder itemList = new StringBuilder();
            foreach (var item in Items)
            {
                if (item.Quantity > 0)
                {
                    itemList.Append($"\t{item.Name}\tquantity: {item.Quantity}, price: {item.Price}\n");
                }
            }

            return itemList.Length > 0 ? itemList.ToString() : App.Get(Message.ItemSoldOut);
        }

        public void Sell(string wantedItem, int wantedQuantity)
        {
            Item item = GetItem(wantedItem);
            if (item != null)
            {
                if (item.Quantity >= wantedQuantity)
                {
                    var hasUserEnoughMoney = wantedQuantity * item.Price <= User.Balance;
                    if (!hasUserEnoughMoney)
                    {
                        App.Show(Message.NotEnoughMoney);
                    }
                    else
                    {
                        item.Quantity -= wantedQuantity;
                        User.Balance -= item.Price * wantedQuantity;
                        App.Show(Message.ItemSold);
                    }
                }
                else if (item.Quantity == 0)
                {
                    App.Show(Message.ItemSoldOut);
                }
                else
                {
                    App.Show(Message.WantedQuantityIsTooHigh);
                }
            }
            else
            {
                App.Show(Message.ItemNotFound);
            }
        }

        public void Add(string targetItem, int targetQuantity)
        {
            Item item = GetItem(targetItem);
            if (item != null)
            {
                item.Quantity += targetQuantity;
                App.Show(Message.ItemAdded);
            }
            else
            {
                App.Show(Message.ItemNotAdded);
            }
        }

        private Item GetItem(string itemName)
        {
            foreach (var item in Items)
            {
                if (String.Equals(item.Name, itemName, StringComparison.CurrentCultureIgnoreCase))
                {
                    return item;
                }
            }

            return null;
        }

        public string GetUserBalance()
        {
            return $"{Math.Round(User.Balance, 2)}";
        }

        public void SetUserBalance(double moneyAmount)
        {
            User.Balance += moneyAmount;
            App.Show(Message.MoneyAdded);
        }
    }
}