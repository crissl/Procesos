using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public class JuegoMinasSteps
    {
        IWebDriver webDriver = new ChromeDriver();
       
        
        [Given(@"registro en el sisitema")]
        public void DadoRegistroEnElSisitema()
        {
            webDriver.Url = "http://localhost:80/JuegoMinas";
        }
        
        [When(@"que ingreso mi nombre ""(.*)""")]
        public void CuandoQueIngresoMi(string nombre)
        {
            /*webDriver*/
            webDriver.Url = "http://localhost:80/JuegoMinas";
            webDriver.Navigate();
            var element =webDriver.FindElement(By.Name("username"));
            element.SendKeys(nombre);
            var boton = webDriver.FindElement(By.Name("aceptar"));
            boton.Click();
        }
        
        [Then(@"el juego inicializa")]
        public void EntoncesElJuegoInicializa()
        {
            Assert.IsTrue(false);
        }
    }
}
