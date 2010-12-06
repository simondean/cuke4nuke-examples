namespace Calculator
{
    using System.Linq;

    public class AddOperation : IOperation
    {
        public decimal Act(decimal[] values)
        {
            return values.Sum();
        }
    }
}