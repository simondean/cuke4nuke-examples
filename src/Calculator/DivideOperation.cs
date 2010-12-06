namespace Calculator
{
    using System.Collections.Generic;

    public class DivideOperation : IOperation
    {
        public decimal Act(IList<decimal> values)
        {
            return values[0]/values[1];
        }
    }
}