using Calculos.Negocio;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public sealed class PromedioSteps
    {
        private readonly ScenarioContext _scenarioContext;
        Promedio promedio;
        int resultado;
        int numero1;
        int numero2;
        public PromedioSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            promedio = new Promedio();
        }
        [Given(@"la sumatoria total de mis notas es (.*)")]
        public void DadoLaSumatoriaTotalDeMisNotasEs(int numero1)
        {
            this.numero1 = numero1;
        }
        
        [Given(@"el numero para dividir es (.*)")]
        public void DadoElNumeroParaDividirEs(int numero2)
        {
            this.numero2 = numero2;
        }
        
        [When(@"los dos numeros se estan dividiendo")]
        public void CuandoLosDosNumerosSeEstanDividiendo()
        {
            resultado = promedio.division(numero1, numero2);
        }
        
        [Then(@"la division da el resultado (.*)")]
        public void EntoncesLaDivisionDaElResultado(int Expected)
        {
            Assert.AreEqual(resultado, Expected);
        }
    }
}
