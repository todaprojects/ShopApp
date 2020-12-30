using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShopApp.Interfaces;
using ShopApp.Services;

namespace ShopApp.Models
{
    public class Shop
    {
        public List<Item> Items { get; set; }
        private IItemSellService ItemSellService { get; set; } = ServiceFactory.GetItemSellService();
        private IItemBalanceService ItemBalanceService { get; set; } = ServiceFactory.GetItemBalanceService();
        
        public Shop()
        {
            Items = new List<Item>();
        }
        
        public string GetItemList()
        {
            var itemList = new StringBuilder();
            foreach (var item in Items.Where(item => item.Quantity > 0))
            {
                itemList.Append($"\t{item.Name}\tquantity: {item.Quantity}, price: {item.Price}\n");
            }

            return itemList.Length > 0 ? itemList.ToString() : "\nThere not any items at the shop!";
        }

        public string SellItem(User user, string buyItem, int buyQuantity)
        {
            return ItemSellService.SellItem(this, user, buyItem, buyQuantity);
        }

        public string AddItem(string addItem, int addQuantity)
        {
            return ItemBalanceService.AddItem(this, addItem, addQuantity);
        }
    }
}