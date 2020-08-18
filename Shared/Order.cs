using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Order
    {
        public string State { get; set; }
        public double SubTotal { get; set; }
        public List<Item> Items { get; set; }
    }
}
