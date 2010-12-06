namespace Calculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Calculator
    {
        private readonly Dictionary<string, IOperation> operations;
        private readonly List<decimal> values = new List<decimal>();

        public Calculator(Dictionary<string, IOperation> operations)
        {
            this.operations = operations;
        }

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

        public static Calculator Create()
        {
            return new Calculator(new Dictionary<string, IOperation>
                                      {
                                          {"add", new AddOperation()},
                                          {"divide", new DivideOperation()}
                                      });
        }
    }
}