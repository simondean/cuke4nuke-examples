namespace Calculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Calculator
    {
        private List<int> values = new List<int>();

        public void Push(int value)
        {
            values.Add(value);
        }

        public string Send(string operation)
        {
            var result = values.Sum();
            values.Clear();
            return result.ToString();
        }
    }
}