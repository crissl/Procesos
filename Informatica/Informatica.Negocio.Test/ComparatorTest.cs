using Microsoft.VisualStudio.TestTools.UnitTesting;
using Informatica.Negocio;


namespace Informatica.Negocio.Test
{
    [TestClass]
     public class ComparatorTest
    {
        [TestMethod]
        public void ObtenerMenor()
        {
            //Triple A => Arrage,Act,
            // Organizar Datos -- Arrage
            var primerElemento = 80;
            var segundoElemento = 40;

            var esperado = 40;

            //ejecutar -- Act
            Comparator comparator = new Comparator();
            int actual = comparator.ObtenerMenor(primerElemento, segundoElemento);
            //Comprobar -- Assert

            Assert.AreEqual(esperado, actual);


        }
    }
}
