namespace step_definitons
{
    using Calculator;
    using Cuke4Nuke.Framework;
    using NUnit.Framework;

    public class CalculatorSteps
    {
        private Calculator calculator;
        private string result;

        [Before]
        public void Before()
        {
            calculator = new Calculator();
        }

        [Given(@"I have entered (\d+) into the calculator")]
        public void given_i_have_entered_a_value(int value)
        {
            calculator.Push(value);
        }

        [When(@"I press (\w+)")]
        public void when_i_press_some_operation(string operation)
        {
            result = calculator.Send(operation);
        }

        [Then(@"the result should be (.*) on the screen")]
        public void then_the_result_should_be_something_on_the_screen(string result)
        {
            Assert.That(this.result, Is.EqualTo(result));
        }
    }
}
