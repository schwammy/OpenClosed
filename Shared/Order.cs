using System.Collections.Generic;

namespace Shared
{
    public class Order
    {
        public string State { get; set; }
        public double SubTotal { get; set; }
        public List<Item> Items { get; set; }
    }
}
