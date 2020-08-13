using Calculos.Negocio;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public sealed class CalculadoraSteps
    {
        private readonly ScenarioContext _scenarioContext;
        Calculadora calculadora;
        int resultado;
        int number1;
        int number2;

        public CalculadoraSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            calculadora = new Calculadora();
        }


        [Given(@"Que si el primer número (.*)")]
        public void DadoQueSiElPrimerNumero(int number1)
        {
            this.number1 = number1;
        }
        
        [Given(@"Que el segundo numero es (.*)")]
        public void DadoQueElSegundoNumeroEs(int number2)
        {
            this.number2 = number2;
        }
        
        [When(@"los dos numerows son sumados")]
        public void CuandoLosDosNumerowsSonSumados()
        {
            resultado = calculadora.suma(number1, number2);
        }
        
        [Then(@"el resultado es (.*)")]
        public void EntoncesElResultadoEs(int Expected)
        {
            Assert.AreEqual(resultado, Expected);
        }
    }
}
