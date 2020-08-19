namespace Shared
{
    public class Item
    {
        public double Price { get; set; }
        public ItemType ItemType { get; set; }
    }

    public enum ItemType
    {
        Food,
        Housewares,
        Electronics,
        Clothes
    }
}
