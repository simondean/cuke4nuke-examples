namespace Calculator
{
    using System.Collections.Generic;

    public interface IOperation
    {
        decimal Act(IList<decimal> values);
    }
}