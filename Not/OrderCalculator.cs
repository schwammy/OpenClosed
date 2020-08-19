using Shared;
using System.Linq;

namespace Not
{
    public class OrderCalculator
    {

        // this could be in a config file
        private double _defaultTaxRate = .05;

        public double CalculateTotal(Order o)
        {
            switch (o.State)
            {
                case "PA":
                    {
                        // rate from db?
                        return o.Items.Sum(i => i.Price) * 1.06;
                    }

                case "NJ":
                    {
                        //taxable
                        var taxable = o.Items.Where(i => i.ItemType != ItemType.Food).Sum(i => i.Price) * 1.0625;
                        //non-taxable
                        var nontaxable = o.Items.Where(i => i.ItemType == ItemType.Food).Sum(i => i.Price);

                        //total
                        return taxable + nontaxable;
                    }

                default:
                    {
                        return o.SubTotal * _defaultTaxRate;
                    }
            }
        }
    }
}
