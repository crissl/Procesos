using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prueba.Negocio;
using System;

namespace Prueba.Test
{
    [TestClass]
    public class FactorialTest
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\Factorial.csv", "Factorial#csv", DataAccessMethod.Sequential),
            DeploymentItem("Factorial.csv")]
        public void Factorial()
        {
            
            var numero1 = Int32.Parse(TestContext.DataRow["numero1"].ToString());
            var numero2 = Int32.Parse(TestContext.DataRow["numero2"].ToString());
            var numero3 = Int32.Parse(TestContext.DataRow["numero3"].ToString());
            /* 
             var numero4 = Int32.Parse(TestContext.DataRow["numeroCuatro"].ToString());
 */
            var esperado = Int32.Parse(TestContext.DataRow["resultado"].ToString());

            var calcular = new Calculadora();
            var actual = calcular.FactorialDeTres(numero1, numero2, numero3);
            Assert.AreEqual(esperado, actual);
        }
    }
}
