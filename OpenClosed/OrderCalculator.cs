using Microsoft.Extensions.Configuration;
using Shared;
using System.Linq;

namespace OpenClosed
{
    public class OrderCalculator
    {
        private readonly ITaxCalculatorFactory _taxCalculatorFactory;

        public double CalculateTotal(Order o)
        {
            //use a factory or ServiceLocator...
            var taxCalc = _taxCalculatorFactory.GetCalculator(o);
            var taxAmount = taxCalc.Calculate(o);

            // other logic here as needed...

            return o.Items.Sum(i => i.Price) + taxAmount;
        }
    }
}
