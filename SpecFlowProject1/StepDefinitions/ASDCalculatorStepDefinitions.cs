using System;
using TechTalk.SpecFlow;
using ClassLibrary;
namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class ASDCalculatorStepDefinitions
    {
        private readonly ScenarioContext scenarioContext;
        private readonly Classadd calculator;
        private int result;
        public ASDCalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
            this.calculator = new Classadd();
        }
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            calculator.Fnum = p0;
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            calculator.Snum = p0;
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            result = calculator.Add();
        }


        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            result = calculator.Sub();
        }

        [When(@"the two numbers are Divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            result = calculator.Div ();
        }
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            result.Should().Be(result);
        }
    }
}
