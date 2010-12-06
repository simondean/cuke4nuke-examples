namespace Calculator
{
    using System.Collections.Generic;
    using System.Linq;

    public class AddOperation : IOperation
    {
        public decimal Act(IList<decimal> values)
        {
            return values.Sum();
        }
    }
}