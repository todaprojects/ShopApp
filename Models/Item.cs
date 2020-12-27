namespace ShopApp.Models
{
    public abstract class Item
    {
        public string Name { get; protected set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}