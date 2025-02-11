
//using FluentAssertions;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly ScenarioContext _scenarioContext;

        private readonly Calculator _calculator = new Calculator();
        private int _result;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
            //throw new PendingStepException();
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic

            _calculator.SecondNumber = number;
            //throw new PendingStepException();
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic

            _result = _calculator.Add();
            //throw new PendingStepException();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            //_result.Should().Be(result);
            Assert.That(_result, Is.EqualTo(result));
            //throw new PendingStepException();
        }
    }
}
