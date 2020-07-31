using Microsoft.VisualStudio.TestTools.UnitTesting;
using Informatica.Negocio;
using System.Collections.Generic;

namespace Informatica.Negocio.Test
{
    [TestClass]
     public class OrdenamientoTest
    {
        [TestMethod]
        public void TresElementosABC()
        {
            // Organizar Datos -- Arrage
            var primero = 80; //A
            var segundo = 40; //B
            var tercero = 20; //C


            var esperado1 = 20;//A
            var esperado2 = 40;//B--C=80


            //ejecutar -- Act
            Ordenamiento ordenamiento = new Ordenamiento();
            List<int> esperados = Ordenamiento.Ordenar(primero, segundo, tercero);
            
            //Comprobar -- Assert

            Assert.AreEqual(esperado1, esperados[0]);
            Assert.AreEqual(esperado2, esperados[1]);
        }
        [TestMethod]
        public void TresElementosACB()
        {
            var primero = 80;//A
            var tercero = 20;//C
            var segundo = 40;//B



            var esperado1 = 20;//A
            var esperado2 = 40;//B--C=80


            //ejecutar -- Act
            Ordenamiento ordenamiento = new Ordenamiento();
            List<int> esperados = Ordenamiento.Ordenar(primero, tercero, segundo);

            //Comprobar -- Assert

            Assert.AreEqual(esperado1, esperados[0]);
            Assert.AreEqual(esperado2, esperados[1]);

        }
        [TestMethod]
        public void TresElementosBAC()
        {
            var segundo = 40;//B
            var primero = 80;//A
            var tercero = 20;//C
           



            var esperado1 = 20;//A
            var esperado2 = 40;//B--C=80


            //ejecutar -- Act
            Ordenamiento ordenamiento = new Ordenamiento();
            List<int> esperados = Ordenamiento.Ordenar(segundo, primero, tercero);

            //Comprobar -- Assert

            Assert.AreEqual(esperado1, esperados[0]);
            Assert.AreEqual(esperado2, esperados[1]);

        }
        [TestMethod]
        public void TresElementosBCA()
        {
            var segundo = 40;//B
            var tercero = 20;//C
            var primero = 80;//A


            var esperado1 = 20;//A
            var esperado2 = 40;//B--C=80


            //ejecutar -- Act
            Ordenamiento ordenamiento = new Ordenamiento();
            List<int> esperados = Ordenamiento.Ordenar(segundo, tercero, primero);

            //Comprobar -- Assert

            Assert.AreEqual(esperado1, esperados[0]);
            Assert.AreEqual(esperado2, esperados[1]);

        }
        [TestMethod]
        public void TresElementosCAB()
        {
            
            var tercero = 20;//C
            var primero = 80;//A
            var segundo = 40;//B

            var esperado1 = 20;//A
            var esperado2 = 40;//B--C=80


            //ejecutar -- Act
            Ordenamiento ordenamiento = new Ordenamiento();
            List<int> esperados = Ordenamiento.Ordenar(tercero, primero, segundo);

            //Comprobar -- Assert

            Assert.AreEqual(esperado1, esperados[0]);
            Assert.AreEqual(esperado2, esperados[1]);

        }
        [TestMethod]
        public void TresElementosCBA()
        {

            var tercero = 20;//C
            var segundo = 40;//B
            var primero = 80;//A

            var esperado1 = 20;//A
            var esperado2 = 40;//B--C=80


            //ejecutar -- Act
            Ordenamiento ordenamiento = new Ordenamiento();
            List<int> esperados = Ordenamiento.Ordenar(tercero, segundo, primero);

            //Comprobar -- Assert

            Assert.AreEqual(esperado1, esperados[0]);
            Assert.AreEqual(esperado2, esperados[1]);

        }
    }
}
