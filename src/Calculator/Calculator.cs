namespace Calculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Calculator
    {
        private readonly List<decimal> values = new List<decimal>();

        public void Push(decimal value)
        {
            values.Add(value);
        }

        public decimal Send(string operation)
        {
            var result = values.Sum();
            values.Clear();
            return result;
        }
    }
}