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
            //Triple A => Arrange, Act, 

            //Arrange--Organizar
            var primerElemento = 80;
            var segundoElemento = 40;

            var esperdo = 40;

            //Act--Ejecutar
            Comparador comparador = new Comparador();
            int actual = comparador.ObtenerMenor(primerElemento, segundoElemento);


            //Assert--Comprobar

            Assert.AreEqual(esperdo, esperdo);

        }
    }
}
