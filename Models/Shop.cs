using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShopApp.Services;

namespace ShopApp.Models
{
    public class Shop
    {
        public List<ItemBalance> Items { get; set; }
        private IItemSellService ItemSellService { get; set; }
        private IItemBalanceService ItemBalanceService { get; set; }
        
        public Shop()
        {
            Items = new List<ItemBalance>();
            ItemSellService = ServiceFactory.GetItemSellService();
            ItemBalanceService = ServiceFactory.GetItemBalanceService();
        }
        
        public string GetItemList()
        {
            var itemList = new StringBuilder();
            foreach (var item in Items.Where(item => item.Quantity > 0))
            {
                itemList.Append($"\t{item.Item.Name}\tquantity: {item.Quantity}, price: {item.Item.Price}\n");
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