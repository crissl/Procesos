
using TechTalk.SpecFlow;

using Calculos.Negocio;
using Microsoft.VisualStudio.TestPlatform;
using NUnit.Framework;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        Calculadora calculadora;
        int resultado;
        int number1;
        int number2;
        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            calculadora = new Calculadora();
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number1)
        {
            this.number1 = number1;
            /*calculadora.PrimerNumero = number1;*/
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number2)
        {
            this.number2 = number2;
            /*calculadora.SengundoNumero = number2;*/
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            resultado = calculadora.suma(number1, number2);
         }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int Expected)
        {
           /* Assert.AreEqual(expectedResult, result);*/
            Assert.AreEqual(resultado, Expected);
        }
    }
}
