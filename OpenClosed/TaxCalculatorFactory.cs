using Shared;

namespace OpenClosed
{
    public interface ITaxCalculatorFactory
    {
        public ITaxCalculator GetCalculator(Order o);
    }
}
